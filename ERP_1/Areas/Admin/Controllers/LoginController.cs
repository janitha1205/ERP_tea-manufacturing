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
                

                    switch (user.info_ID)
                        {
                            case 1: UserStatic.isAdmin = false;
                                LogBLL.AddLog(General.Messegess.AddSuccess, "login as a Machine operator");
                                return RedirectToAction("MetaList_MO", "MO");
                                
                            case 2:
                                UserStatic.isAdmin = false;
                                LogBLL.AddLog(General.Messegess.AddSuccess, "login as a Machine operator asistant");
                                return RedirectToAction("MetaList_MO", "MO");
                                
                            case 3:
                                UserStatic.isAdmin = false;
                                LogBLL.AddLog(General.Messegess.AddSuccess, "login as a mechanic");
                                return RedirectToAction("MetaList_ST", "ST");
                                
                            case 4:
                                UserStatic.isAdmin = false;
                                LogBLL.AddLog(General.Messegess.AddSuccess, "login as a assistant mechanic");
                                return RedirectToAction("MetaList_ST", "ST");
                                
                            case 5:
                                UserStatic.isAdmin = false;
                                LogBLL.AddLog(General.Messegess.AddSuccess, "login as a production executive");
                                return RedirectToAction("MetaList_PE", "PE");
                               
                            case 6:
                                UserStatic.isAdmin = false;
                                LogBLL.AddLog(General.Messegess.AddSuccess, "login as a production manager");
                                return RedirectToAction("MetaList_PM", "PM");
                               
                            case 7:
                                UserStatic.isAdmin = false;
                                LogBLL.AddLog(General.Messegess.AddSuccess, "login as a factory engineer");
                                return RedirectToAction("MetaList_FE", "FE");
                                
                            case 8:
                                UserStatic.isAdmin = false;
                                LogBLL.AddLog(General.Messegess.AddSuccess, "login as a HR executive");
                                return RedirectToAction("MetaList_HRE", "HRE");
                                
                            case 12:
                                UserStatic.isAdmin = false;
                                LogBLL.AddLog(General.Messegess.AddSuccess, "login as a factory manager");
                                return RedirectToAction("MetaList_FM", "FM");
                                
                            case 13:
                                UserStatic.isAdmin = false;
                                LogBLL.AddLog(General.Messegess.AddSuccess, "login as a Store executive");
                                return RedirectToAction("MetaList_SE", "SE");
                                
                            case 14:
                                UserStatic.isAdmin = false;
                                LogBLL.AddLog(General.Messegess.AddSuccess, "login as a HR manager");
                                return RedirectToAction("MetaList_HRM", "HRM");
                                
                            case 15:
                                UserStatic.isAdmin = true;
                                LogBLL.AddLog(General.Messegess.AddSuccess, "login as a admin");
                                return RedirectToAction("UseList", "User");
                               
                            case 16:
                                UserStatic.isAdmin = false;
                                LogBLL.AddLog(General.Messegess.AddSuccess, "login as a trainee");
                                return View(dto);

                            default:
                                return View(dto);
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
