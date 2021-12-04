using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVC.Controllers
{
    public class My1Controller : Controller
    {
        public IActionResult Index(int? id) {
            ViewData["akcja"] = ControllerContext.ActionDescriptor.ActionName;
            ViewData["kontroler"] = ControllerContext.ActionDescriptor.ControllerName;
            ViewBag.Id = id;
            return View();
        }
    }
}
