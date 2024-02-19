using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_1.Areas.Admin.Controllers
{
    public class HRMController : Controller
    {
        // GET: Admin/HRM
        
        MetaBLL_HRM bllhrm = new MetaBLL_HRM();
 
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddMeta_HRM()
        {

            MetaDTO_HRM dto = new MetaDTO_HRM();
            return View(dto);


        }
        [HttpPost]
        public ActionResult AddMeta_HRM(MetaDTO_HRM model)
        {
            if (ModelState.IsValid)
            {

                if (bllhrm.AddMeta(model))
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
            MetaDTO_HRM newmodel = new MetaDTO_HRM();
            return View(newmodel);

        }
        public ActionResult UpdateMata_HRM(int id)
        {
            MetaDTO_HRM model = new MetaDTO_HRM();
            model = bllhrm.GetMetaWithID(id);
            return View(model);

        }
        [HttpPost]
        public ActionResult UpdateMata_HRM(MetaDTO_HRM model)
        {
            if (ModelState.IsValid)
            {
                if (bllhrm.UpdateMeta(model))
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


        public ActionResult MetaList_HRM()
        {
            List<MetaDTO_HRM> list = new List<MetaDTO_HRM>();
            list = bllhrm.GetMetaData_HRM();
            return View(list);

        }


    }
}