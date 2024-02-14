using ERP_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages.Html;

namespace ERP_1.Controllers
{ 
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            Dictionary<int, Product> list_p = new Dictionary<int, Product>();
            Product pr= new Product();
            list_p.Add(list_p.Count, pr);   
            return View(list_p);
        }
        public ActionResult AddProduct()
        {
            Product me1 = new Product();
            return View(me1);
        }
        [HttpPost]
        public ActionResult AddProduct(Product predct)
        {
            string textvalid = "";
            if (ModelState.IsValid)
                textvalid = "Model state is valid";
            else
                textvalid = "Model state is invalid";
            

            return View(predct);
        }
        public ActionResult UpdateProduct()
        {
            Product pre2 = new Product();
           
            return View(pre2);

            
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product pre1)
        {
            return View(pre1);
        }

    }
}



