using ERP_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages.Html;

namespace ERP_1.Controllers
{
    public class WorkInProcessController : Controller
    {
        // GET: WorkInProcesst
        public ActionResult Index()
        {
            Dictionary<int, WorkInProcess> list_wip = new Dictionary<int, WorkInProcess>();
            WorkInProcess wip = new WorkInProcess();
            list_wip.Add(list_wip.Count, wip);
            return View(list_wip);

        }
        public ActionResult AddWorkInProcess()
        {
            WorkInProcess mat12 = new WorkInProcess();
            return View(mat12);
        }
        [HttpPost]
        public ActionResult AddWorkInProcess(WorkInProcess mat123)
        {
            string textvalid = "";
            if (ModelState.IsValid)
                textvalid = "Model state is valid";
            else
                textvalid = "Model state is invalid";
            
            return View(mat123);
        }



        public ActionResult UpdateWorkInProcess()
        {
            WorkInProcess mat23 = new WorkInProcess();
            return View(mat23);
           
        }
        [HttpPost]
        public ActionResult UpdateWorkInProcess(WorkInProcess mat34)
        {
            return View(mat34);
        }
    }
}


