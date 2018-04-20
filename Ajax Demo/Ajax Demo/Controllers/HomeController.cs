using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ajax_Demo.Models;

namespace Ajax_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public JsonResult LoadData()
        {
            var listEmployee = new List<EmployeeModels>();
            listEmployee.Add(new EmployeeModels()
            {
                ID = 1,
                Name = "Nguyen Van A",
                Salary = 200000,
                Status = true
            });
            listEmployee.Add(new EmployeeModels()
            {
                ID = 2,
                Name = "Nguyen Van B",
                Salary = 2300000,
                Status = false
            });
            listEmployee.Add(new EmployeeModels()
            {
                ID = 3,
                Name = "Nguyen Thi C",
                Salary = 234400000,
                Status = true
            });
            return Json(new
            {
                data=listEmployee,
                status= true
            },JsonRequestBehavior.AllowGet);
        }
    }
}