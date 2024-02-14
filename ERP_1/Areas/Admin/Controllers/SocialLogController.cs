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
    public class SocialLogController : Controller
    {
        SocialLogBLL bll= new SocialLogBLL();
        // GET: Admin/SocialLog
        public ActionResult AddSocialLog()
        {
            SocialLogDTO socialLog = new SocialLogDTO();    
            return View(socialLog);
        }
        [HttpPost]
        public ActionResult AddSocialLog(SocialLogDTO dto)
        {
            if (dto.SocialImage == null)
            {
                ViewBag.ProcessState = General.Messegess.ImageMissing;
                return View(dto);
            }else if (ModelState.IsValid)
            {
                HttpPostedFileBase postedfile = dto.SocialImage;
                Bitmap Socialmedia = new Bitmap(postedfile.InputStream);
                string ext = Path.GetExtension(postedfile.FileName);
                string filename = "";
                if(ext==".jpg"|| ext == ".jpeg"|| ext == ".png"|| ext == ".gif") {

                    string uniqname=Guid.NewGuid().ToString();
                    filename = uniqname + postedfile.FileName;
                    Socialmedia.Save(Server.MapPath("~/Areas/Admin/content/socialmediaimagess/" + filename));
                    dto.ImagePath = filename;
                    if (bll.AddSocialLog(dto)) 
                    {
                        ViewBag.ProcessState=General.Messegess.AddSuccess;
                        dto=new SocialLogDTO();
                        ModelState.Clear();

                    }
                    else
                    {
                        ViewBag.ProcessState = General.Messegess.GenaralError;
                    }
                }
                else
                {
                    ViewBag.ProcessState = General.Messegess.ExtensionError;
                }
            }
            else
            {
                ViewBag.ProcessState = General.Messegess.EmptyArea;
            }
            return View(dto);

        }

        public ActionResult SocialLogList() { 
        
            List<SocialLogDTO> list = new List<SocialLogDTO>();

            list = bll.GetSocialLog();
            return View(list);
        }
        public ActionResult UpdateSocialLog(int ID)
        {
            SocialLogDTO dto = bll.GetSocialLogByID(ID);  
            return View(dto);

        }
        [HttpPost]
        public ActionResult UpdateSocialLog(SocialLogDTO model)
        {
            return View(model);

        }

    }
}