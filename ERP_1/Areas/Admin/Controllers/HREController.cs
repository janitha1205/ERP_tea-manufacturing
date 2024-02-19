using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_1.Areas.Admin.Controllers
{
    public class HREController : Controller
    {
        MetaBLL_HRE bllhre = new MetaBLL_HRE();
        // GET: Admin/HRE
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddMeta_HRE()
        {

            MetaDTO_HRE dto = new MetaDTO_HRE();
            return View(dto);


        }
        [HttpPost]
        public ActionResult AddMeta_HRE(MetaDTO_HRE model)
        {
            if (ModelState.IsValid)
            {

                if (bllhre.AddMeta(model))
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
            MetaDTO_HRE newmodel = new MetaDTO_HRE();
            return View(newmodel);

        }
        public ActionResult UpdateMata_HRE(int id)
        {
            MetaDTO_HRE model = new MetaDTO_HRE();
            model = bllhre.GetMetaWithID(id);
            return View(model);

        }
        [HttpPost]
        public ActionResult UpdateMata_HRE(MetaDTO_HRE model)
        {
            if (ModelState.IsValid)
            {
                if (bllhre.UpdateMeta(model))
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
        public ActionResult MetaList_HRE()
        {
            List<MetaDTO_HRE> list = new List<MetaDTO_HRE>();
            list = bllhre.GetMetaData_HRE();
            return View(list);

        }
    }
}