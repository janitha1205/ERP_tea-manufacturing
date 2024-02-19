using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_1.Areas.Admin.Controllers
{
    public class MOController : Controller
    {
        // GET: Admin/MO
        MetaBLL_MO bllmo = new MetaBLL_MO();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddMeta_MO()
        {

            MetaDTO_MO dto = new MetaDTO_MO();
            return View(dto);


        }
        [HttpPost]
        public ActionResult AddMeta_MO(MetaDTO_MO model)
        {
            if (ModelState.IsValid)
            {

                if (bllmo.AddMeta(model))
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
            MetaDTO_MO newmodel = new MetaDTO_MO();
            return View(newmodel);

        }
        public ActionResult UpdateMata_MO(int id)
        {
            MetaDTO_MO model = new MetaDTO_MO();
            model = bllmo.GetMetaWithID(id);
            return View(model);

        }
        [HttpPost]
        public ActionResult UpdateMata_MO(MetaDTO_MO model)
        {
            if (ModelState.IsValid)
            {
                if (bllmo.UpdateMeta(model))
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


        public ActionResult MetaList_MO()
        {
            List<MetaDTO_MO> list = new List<MetaDTO_MO>();
            list = bllmo.GetMetaData_MO();
            return View(list);

        }
    }
}