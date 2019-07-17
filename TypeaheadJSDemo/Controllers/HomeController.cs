using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TypeaheadJSDemo.Models;

namespace TypeaheadJSDemo.Controllers
{
    public class HomeController : Controller
    {
        Context _context = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetList(string name)
        {
            var list = _context.TypeAheads.Where(x => x.Name.StartsWith(name)).Take(10).ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}