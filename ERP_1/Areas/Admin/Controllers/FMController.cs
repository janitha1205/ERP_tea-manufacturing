using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_1.Areas.Admin.Controllers
{
    public class FMController : Controller
    {
        MetaBLL_FM bllfm = new MetaBLL_FM();
        // GET: Admin/FM
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddMeta_FM()
        {

            MetaDTO_FM dto = new MetaDTO_FM();
            return View(dto);


        }
        [HttpPost]
        public ActionResult AddMeta_FM(MetaDTO_FM model)
        {
            if (ModelState.IsValid)
            {

                if (bllfm.AddMeta(model))
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
            MetaDTO_FM newmodel = new MetaDTO_FM();
            return View(newmodel);

        }
        public ActionResult UpdateMata_FM(int id)
        {
            MetaDTO_FM model = new MetaDTO_FM();
            model = bllfm.GetMetaWithID(id);
            return View(model);

        }
        [HttpPost]
        public ActionResult UpdateMata_FM(MetaDTO_FM model)
        {
            if (ModelState.IsValid)
            {
                if (bllfm.UpdateMeta(model))
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
        public ActionResult MetaList_FM()
        {
            List<MetaDTO_FM> list = new List<MetaDTO_FM>();
            list = bllfm.GetMetaData_FM();
            return View(list);

        }

    }
}