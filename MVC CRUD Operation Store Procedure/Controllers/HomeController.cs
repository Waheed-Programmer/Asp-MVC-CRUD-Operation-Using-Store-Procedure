using MVC_CRUD_Operation_Store_Procedure.Models;
using MVC_CRUD_Operation_Store_Procedure.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CRUD_Operation_Store_Procedure.Controllers
{
    public class HomeController : Controller
    {
        DAL db = new DAL();


        public ActionResult List()
        {
            var data = db.GetEmloye();

            return View(data);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
       [HttpPost]
        public ActionResult Add(EmployeModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DAL sdb = new DAL();
                    if (sdb.InsertEmploye(model))
                    {
                        ViewBag.Message = "Employe Details Added Successfully";
                        RedirectToAction("List");

                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}