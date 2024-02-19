using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_1.Areas.Admin.Controllers
{
    public class STController : Controller
    {
        MetaBLL_ST bllst = new MetaBLL_ST();
        // GET: Admin/ST
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AddMeta_ST()
        {

            MetaDTO_ST dto = new MetaDTO_ST();
            return View(dto);


        }
        [HttpPost]
        public ActionResult AddMeta_ST(MetaDTO_ST model)
        {
            if (ModelState.IsValid)
            {

                if (bllst.AddMeta(model))
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
            MetaDTO_ST newmodel = new MetaDTO_ST();
            return View(newmodel);

        }


        public ActionResult UpdateMata_ST(int id)
        {
            MetaDTO_ST model = new MetaDTO_ST();
            model = bllst.GetMetaWithID(id);
            return View(model);

        }
        [HttpPost]
        public ActionResult UpdateMata_ST(MetaDTO_ST model)
        {
            if (ModelState.IsValid)
            {
                if (bllst.UpdateMeta(model))
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










        public ActionResult MetaList_ST()
        {
            List<MetaDTO_ST> list = new List<MetaDTO_ST>();
            list = bllst.GetMetaData_ST();
            return View(list);

        }
    }
}