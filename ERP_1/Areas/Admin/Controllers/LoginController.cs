using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace ERP_1.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        UserBLL userbll=new UserBLL();
        // GET: Admin/Login
        public ActionResult Index() { 
        
            UserDTO dto = new UserDTO();
            return View(dto);
        }
        [HttpPost]
        public ActionResult Index(UserDTO dto) {

            if (ModelState.IsValid)
            {
                
                UserDTO user = userbll.GetUserWithUsernameAndPassword(dto);
                if(user.ID!=0)
                {
                    UserStatic.ID = user.ID;
                    UserStatic.Name = user.Name;
                    UserStatic.SureName = user.SureName;
                    if (user.info_ID == 15) {
                        UserStatic.isAdmin = true;
                        LogBLL.AddLog(General.Messegess.AddSuccess, "Login as admin", 5);
                        return RedirectToAction("Index", "Post");
                    }
                    else {
                        UserStatic.isAdmin = false;
                        LogBLL.AddLog(General.Messegess.AddSuccess, "login as a user", 5);
                        return RedirectToAction("AddMeta", "Meta");
                    }
                   
                }
                else { return View(dto); }
            }
            else
            {
                return View(dto);
            }

        
        
        }
    }
}

