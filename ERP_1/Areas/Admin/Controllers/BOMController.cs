using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_1.Areas.Admin.Controllers
{
    public class BOMController : Controller
    {
        // GET: Admin/BOM

        BomBLL bombll = new BomBLL();
          


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult starbom() {

        




            BOMDTO bOM = new BOMDTO();
            return View(bOM); 
        }

        [HttpPost]
     
        public ActionResult starbom(BOMDTO model) {

            if (ModelState.IsValid)
            {

                if (bombll.AddMeta(model))
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
            BOMDTO newmodel = new BOMDTO();
            return View(newmodel);

            
        }
        public ActionResult processdisp()
        {
            BomAdv bomadv= new BomAdv();
            View(bomadv);

        }
        [HttpPost]
        public ActionResult processdisp(BOMDTO model)
        {
            if (bomadv.AddMeta(model))
            {
                ViewBag.ProcessState = General.Messegess.AddSuccess;
            }
            BomAdv bomadv2=new BomAdv(); 
            return View(bomadv2);

        }
    }

}