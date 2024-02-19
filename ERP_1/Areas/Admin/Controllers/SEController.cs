using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_1.Areas.Admin.Controllers
{
    public class SEController : Controller
    {
        // GET: Admin/SE
        MetaBLL_SE bllse = new MetaBLL_SE();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddMeta_SE()
        {

            MetaDTO_SE dto = new MetaDTO_SE();
            return View(dto);


        }
        [HttpPost]
        public ActionResult AddMeta_SE(MetaDTO_SE model)
        {
            if (ModelState.IsValid)
            {

                if (bllse.AddMeta(model))
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
            MetaDTO_SE newmodel = new MetaDTO_SE();
            return View(newmodel);

        }

        public ActionResult MetaList_SE()
        {
            List<MetaDTO_SE> list = new List<MetaDTO_SE>();
            list = bllse.GetMetaData_SE();
            return View(list);

        }

        public ActionResult UpdateMata_SE(int id)
        {
            MetaDTO_SE model = new MetaDTO_SE();
            model = bllse.GetMetaWithID(id);
            return View(model);

        }
        [HttpPost]
        public ActionResult UpdateMata_SE(MetaDTO_SE model)
        {
            if (ModelState.IsValid)
            {
                if (bllse.UpdateMeta(model))
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




    }
}