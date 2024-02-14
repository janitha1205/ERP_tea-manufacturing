using ERP_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages.Html;

namespace ERP_1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        public ActionResult Index()
        {
            Dictionary<int, Employee> list_n = new Dictionary<int, Employee>();
            Employee emp1 = new Employee("janitha", "thalagoda");
            list_n.Add(list_n.Count, emp1);
            Employee emp2 = new Employee("anil", "senadeera");
            ViewData["Name"] = emp1.Name;
            ViewBag.SureName= emp2.SureName;
            TempData["temp"] = emp1.SureName;
            list_n.Add(list_n.Count, emp2);
            return View(list_n);

        }
  
        public JsonResult GetDateWithJson() 
        {
            string JsonDate = DateTime.Today.ToShortDateString();
            return Json(JsonDate);
        }
        public ActionResult AddEmployee()
        {
            Employee employee = new Employee();

            return View(employee);
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            string textvalid = "";
            if (ModelState.IsValid)
                textvalid = "Model state is valid";
            else
                textvalid = "Model state is invalid";
            return View(employee);
        }
        public ActionResult UpdateEmployee()
        {
            Employee employee1 = new Employee();
            string comp = (string)TempData["temp"];
            employee1.Name =comp;
            employee1.SureName = "anurasiri";
            return View(employee1);
        }
        [HttpPost]
        public ActionResult UpdateEmployee(Employee employee2)
        {
            return View(employee2);
        }
    }
}