using ERP_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages.Html;
namespace ERP_1.Controllers
{
    public class MechineController : Controller
    {
        // GET: Machine
        public ActionResult Index()
        {


            Dictionary<int, Mechine> list_m = new Dictionary<int, Mechine>();
            Mechine emp1 = new Mechine();
            list_m.Add(list_m.Count, emp1);
            return View(list_m);

            
        }
        public ActionResult AddMechines()
        {
            Mechine me = new Mechine();
            return View(me);
        }

        [HttpPost]
        public ActionResult AddMechines(Mechine mech)
        {
            string textvalid = "";
            if (ModelState.IsValid)
                textvalid = "Model state is valid";
            else
                textvalid = "Model state is invalid";
           

            return View(mech);
        }
        public ActionResult UpdateMechines()
        {
            Mechine mesh = new Mechine();
            mesh.MechName = "";
            mesh.LabourID = 0;
            mesh.Description = "nothing";
            mesh.IsDown = false;
            mesh.HoursWorked = 2;
            mesh.Type = "packing";

            return View(mesh);
        }
        [HttpPost]
        public ActionResult UpdateMechines(Mechine mesh)
        {
            return View(mesh);
        }

     

        












    }
}