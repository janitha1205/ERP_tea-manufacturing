using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_1.Areas.Admin.Controllers
{
    public class MechinesController : Controller
    {
        // GET: Admin/Mechines
        MechineBLL bllmech = new MechineBLL();
        public ActionResult Index()
        {
            return View();
        }
    


        public ActionResult AddMechines()
        {

            mechineDTO dto = new mechineDTO();
            return View(dto);


        }
        [HttpPost]
        public ActionResult AddMechines(mechineDTO model)
        {
            if (ModelState.IsValid)
            {

                if (bllmech.AddMechine(model))
                {
                    ViewBag.ProcessState = General.Messegess.AddSuccess;
                    ModelState.Clear();

                }
                else
                {
                    ViewBag.ProcessState = General.Messegess.GenaralError;
                }
            }
            else
            {

                ViewBag.ProcessState = General.Messegess.EmptyArea;


            }
            mechineDTO newmodel = new mechineDTO();
            return View(newmodel);

        }






    }
}