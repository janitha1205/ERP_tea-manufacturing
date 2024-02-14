using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_1.Areas.Admin.Controllers
{
    public class MetaController : Controller
    {
        MetaBLL bll = new MetaBLL();    
        // GET: Admin/Meta
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddMeta() {
        
            MetaDTO dto= new MetaDTO();
            return View(dto);

           
        }
        [HttpPost]
        public ActionResult AddMeta(MetaDTO model)
        {
            if (ModelState.IsValid)
            {

                if (bll.AddMeta(model))
                {
                    ViewBag.ProcessState = General.Messegess.AddSuccess;
                    ModelState.Clear();
                }
                else {
                    ViewBag.ProcessState = General.Messegess.GenaralError;
                }
            }
            else
            {

                ViewBag.ProcessState = General.Messegess.EmptyArea;


            }
            MetaDTO newmodel = new MetaDTO();
            return View(newmodel);

        }
        public ActionResult MetaList()
        {
            List<MetaDTO> list = new List<MetaDTO>();
            list = bll.GetMetaData();
            return View(list);

        }
        public ActionResult UpdateMata(int id) 
        {
            MetaDTO model = new MetaDTO();
            model = bll.GetMetaWithID(id);
            return View(model);
        
        }
        [HttpPost]
        public ActionResult UpdateMata(MetaDTO model) {
            if (ModelState.IsValid)
            {
                if (bll.UpdateMeta(model))
                {
                    ViewBag.ProcessState = General.Messegess.UpdateSuccess;
                }
                else
                {
                    ViewBag.ProcessState = General.Messegess.GenaralError;
                }

            }
            else {
                ViewBag.ProcessState= General.Messegess.EmptyArea;
            
            }
            return View(model);
        
        }

    }
}


