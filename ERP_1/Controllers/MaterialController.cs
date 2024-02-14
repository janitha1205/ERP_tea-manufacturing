using ERP_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages.Html;

namespace ERP_1.Controllers
{
    public class MaterialController : Controller
    {
        // GET: Material
        public ActionResult Index()
        {
            Dictionary<int, Material> list_mat = new Dictionary<int, Material>();
            Material mat = new Material();
            list_mat.Add(list_mat.Count, mat);
            return View(list_mat);
            
        }
        public ActionResult AddMaterial()
        {
            Material mat12 = new Material();
            return View(mat12);
        }
        [HttpPost]
        public ActionResult AddMaterial(Material mat123)
        {
            string textvalid = "";
            if (ModelState.IsValid)
                textvalid = "Model state is valid";
            else
                textvalid = "Model state is invalid";
           
            return View(mat123);
        }
        public ActionResult UpdateMaterial()
        {
            Material mat23= new Material();
            return View(mat23);
        }
        [HttpPost]
        public ActionResult UpdateMaterial(Material mat34)
        {
            return View(mat34);
        }
    }
}

