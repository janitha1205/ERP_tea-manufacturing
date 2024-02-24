using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_1.Areas.Admin.Controllers
{
    public class BOMadnvacedController : Controller
    {
        BomadvBLL bomadvbll = new BomadvBLL();
        // GET: Admin/BOMadnvaced
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Processdisp()
        {
            BomAdv bomadv2 = new BomAdv();
            return View(bomadv2);

        }


        [HttpPost]
        public ActionResult Processdisp(BomAdv model)
        {
            if (ModelState.IsValid)
            {
                if (bomadvbll.AddMeta(model))
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
            BomAdv bomadv21 = new BomAdv();
            return View(bomadv21);

        }
    }


}