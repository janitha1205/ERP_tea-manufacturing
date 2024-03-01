using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_1.Areas.Admin.Controllers
{
    
    public class UserController : Controller
    {
        UserBLL bll = new UserBLL();
        // GET: Admin/User
        public ActionResult AddUser() { 
            UserDTO userDTO = new UserDTO();    
            return View(userDTO);
        }
        [HttpPost]
        public ActionResult AddUser(UserDTO dto)
        {
            if (dto.UserImage == null)
            {
                ViewBag.ProcessState = General.Messegess.ImageMissing;
            }
            else
            {
                if (ModelState.IsValid)
                {
                    string filename = "";
                    HttpPostedFileBase postedfile= dto.UserImage;
                    Bitmap userimage = new Bitmap(postedfile.InputStream);
                    Bitmap resizeim = new Bitmap(userimage, 120, 120);
                    string ext = Path.GetExtension(postedfile.FileName);
                    if (ext == ".jpg" || ext == ".png" || ext == ".jpeg" || ext == ".gif")
                    {
                        string uniqnum = Guid.NewGuid().ToString();  
                        filename=uniqnum+postedfile.FileName;
                        resizeim.Save(Server.MapPath("~/Areas/Admin/content/UserImage/"+filename));
                        dto.imagepath = filename;
                        bll.AddUser(dto);
                        ViewBag.ProcessState=General.Messegess.AddSuccess;
                        ModelState.Clear();

                    }
                    else
                    {
                        ViewBag.ProcessState = General.Messegess.ExtensionError;
                    }
                }
                else
                {
                    ViewBag.ProcessState=General.Messegess.EmptyArea;    
                }
               
            }
            return View(dto);
        }
        public ActionResult UserList()
        {
            List<UserDTO> list= new List<UserDTO>();
            list = bll.GetUsers();
            return View(list);
        }
        public ActionResult UpdateUser(int id) 
        {
            UserDTO dto = new UserDTO();
            dto = bll.GetUserWithID(id);
            return View(dto);
        
       
        }
        [HttpPost]
        public ActionResult UpdateUser(UserDTO dto)
        {
            if (!ModelState.IsValid)
            {

                ViewBag.ProcessState = General.Messegess.EmptyArea;

            }
            else
            {
                if (dto.UserImage != null)
                {
                    string filename = "";
                    HttpPostedFileBase postedfile = dto.UserImage;
                    Bitmap userimage = new Bitmap(postedfile.InputStream);
                    Bitmap resizeim = new Bitmap(userimage, 120, 120);
                    string ext = Path.GetExtension(postedfile.FileName);
                    if (ext == ".jpg" || ext == ".png" || ext == ".jpeg" || ext == ".gif")
                    {
                        string uniqnum = Guid.NewGuid().ToString();
                        filename = uniqnum + postedfile.FileName;
                        resizeim.Save(Server.MapPath("~/Areas/Admin/content/UserImage/" + filename));
                        dto.imagepath = filename;
                    }
                }
                string oldimgpath = bll.UpdateUser(dto);
                if (dto.UserImage != null)
                {

                
                    if (System.IO.File.Exists(Server.MapPath("~/Areas/Admin/content/UserImage" + oldimgpath)))

                    {
                        System.IO.File.Delete(Server.MapPath("~/Areas/Admin/content/UserImage/" + oldimgpath));


                    }
                    ViewBag.ProcessState = General.Messegess.UpdateSuccess;
                }

            }
            return View(dto);
        }
  
    }
    
}
