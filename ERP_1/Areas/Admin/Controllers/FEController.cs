using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_1.Areas.Admin.Controllers
{
    public class FEController : Controller
    {
        MetaBLL_FE bllfe = new MetaBLL_FE();
        // GET: Admin/FE
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddMeta_FE()
        {

            MetaDTO_FE dto = new MetaDTO_FE();
            return View(dto);


        }
        [HttpPost]
        public ActionResult AddMeta_FE(MetaDTO_FE model)
        {
            if (ModelState.IsValid)
            {

                if (bllfe.AddMeta(model))
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
            MetaDTO_FE newmodel = new MetaDTO_FE();
            return View(newmodel);

        }


        public ActionResult UpdateMata_FE(int id)
        {
            MetaDTO_FE model = new MetaDTO_FE();
            model = bllfe.GetMetaWithID(id);
            return View(model);

        }
        [HttpPost]
        public ActionResult UpdateMata_FE(MetaDTO_FE model)
        {
            if (ModelState.IsValid)
            {
                if (bllfe.UpdateMeta(model))
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
        
        public ActionResult MetaList_FE()
        {
            List<MetaDTO_FE> list = new List<MetaDTO_FE>();
            list = bllfe.GetMetaData_FE();
            return View(list);

        }
 

    }
}