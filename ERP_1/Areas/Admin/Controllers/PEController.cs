using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_1.Areas.Admin.Controllers
{
    public class PEController : Controller
    {
        MetaBLL_PE bllpe = new MetaBLL_PE();
        // GET: Admin/PE
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AddMeta_PE()
        {

            MetaDTO_PE dto = new MetaDTO_PE();
            return View(dto);


        }
        [HttpPost]
        public ActionResult AddMeta_PE(MetaDTO_PE model)
        {
            if (ModelState.IsValid)
            {

                if (bllpe.AddMeta(model))
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
            MetaDTO_PE newmodel = new MetaDTO_PE();
            return View(newmodel);

        }


        public ActionResult UpdateMata_PE(int id)
        {
            MetaDTO_PE model = new MetaDTO_PE();
            model = bllpe.GetMetaWithID(id);
            return View(model);

        }
        [HttpPost]
        public ActionResult UpdateMata_PE(MetaDTO_PE model)
        {
            if (ModelState.IsValid)
            {
                if (bllpe.UpdateMeta(model))
                {
                    ViewBag.ProcessState = General.Messegess.UpdateSuccess;
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
            return View(model);

        }












        public ActionResult MetaList_PE()
        {
            List<MetaDTO_PE> list = new List<MetaDTO_PE>();
            list = bllpe.GetMetaData_PE();
            return View(list);

        }

    }
}