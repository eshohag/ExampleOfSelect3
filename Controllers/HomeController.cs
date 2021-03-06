using ExampleOfSelect3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ExampleOfSelect3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var list = new List<DropdownList>();

            for (int i = 0; i < 3000000; i++)
            {
                list.Add(new DropdownList() { id = i, text = "Test Data-" + i });
            }

            //var serializer = new System.Web.Script.Serialization.JavaScriptSerializer() { MaxJsonLength = Int32.MaxValue };
            //ViewBag.DataAsList = serializer.Serialize(list);

            ViewBag.DataAsList = JsonConvert.SerializeObject(list);

            return View();
        }
    }
}
