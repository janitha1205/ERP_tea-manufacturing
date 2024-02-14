using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return Redirect("www.facebook.com");
        }
        public ActionResult Firstaction()
        {
            return View();
        }
        public ActionResult GotoProduct()
        {
            return RedirectToAction("Index","Product");
        }
        public ActionResult GotoUpdateProduct()
        {
            return RedirectToAction("UpdateProduct", "Product", new { ID = 20, name="ajantha" });
        }
        public ActionResult GotoMachine()
        {
            return RedirectToAction("Index", "Mechine");
        }
        public ActionResult GotoUpdateMachine()
        {
            return RedirectToAction("UpdateMechine", "Mechine", new { ID = 20, name = "ajantha" });
        }
        public ActionResult GotoEmployee()
        {
            return RedirectToAction("Index", "Employee");
        }
        public ActionResult GotoUpdateEmployee()
        {
            return RedirectToAction("UpdateEmployee", "Employee", new { ID = 20, name = "ajantha" });
        }
        public ActionResult GotoMaterial()
        {
            return RedirectToAction("Index", "Material");
        }
        public ActionResult GotoUpdateMaterial()
        {
            return RedirectToAction("UpdateMaterial", "Material", new { ID = 20, name = "ajantha" });
        }
        public ActionResult GotoWorkInProcesst()
        {
            return RedirectToAction("Index", "WorkInProcess");
        }
        public ActionResult GotoUpdateWorkInProcesstt()
        {
            return RedirectToAction("UpdateWorkInProcess", "WorkInProcess", new { ID = 20, name = "ajantha" });
        }
    }
}