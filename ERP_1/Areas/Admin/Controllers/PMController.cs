using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_1.Areas.Admin.Controllers
{
    public class PMController : Controller
    {
        MetaBLL_PM bllpm = new MetaBLL_PM();
        // GET: Admin/PM
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AddMeta_PM()
        {

            MetaDTO_PM dto = new MetaDTO_PM();
            return View(dto);


        }
        [HttpPost]
        public ActionResult AddMeta_PM(MetaDTO_PM model)
        {
            if (ModelState.IsValid)
            {

                if (bllpm.AddMeta(model))
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
            MetaDTO_PM newmodel = new MetaDTO_PM();
            return View(newmodel);

        }

        public ActionResult UpdateMata_PM(int id)
        {
            MetaDTO_PM model = new MetaDTO_PM();
            model = bllpm.GetMetaWithID(id);
            return View(model);

        }
        [HttpPost]
        public ActionResult UpdateMata_MO(MetaDTO_PM model)
        {
            if (ModelState.IsValid)
            {
                if (bllpm.UpdateMeta(model))
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

        public ActionResult MetaList_PM()
        {
            List<MetaDTO_PM> list = new List<MetaDTO_PM>();
            list = bllpm.GetMetaData_PM();
            return View(list);

        }
    }
}