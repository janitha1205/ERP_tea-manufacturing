using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_1.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult AddUser() { 
            UserDTO userDTO = new UserDTO();    
            return View(userDTO);
        }
  
    }
}