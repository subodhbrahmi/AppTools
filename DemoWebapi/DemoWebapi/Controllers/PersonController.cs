using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DemoWebapi.Models;

namespace DemoWebapi.Controllers
{
    public class PersonController : Controller
    {
        ValuesController db = new ValuesController();

        public ActionResult Index()
        {
            var list = db.Get(); // Gets the list of records from web api
            return View(list);
        }

        public ActionResult Index2()
        {
            return View();
        }
    }
}
