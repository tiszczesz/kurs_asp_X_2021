using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVC.Controllers
{
    public class My1Controller : Controller
    {
        [HttpGet]
        public IActionResult Index(int rows=2,int cols=2) {
            ViewData["akcja"] = ControllerContext.ActionDescriptor.ActionName;
            ViewData["kontroler"] = ControllerContext.ActionDescriptor.ControllerName;
            ViewBag.rows = rows;
            ViewBag.cols = cols;
            ViewBag.html = GenerTab(rows, cols);
            return View();
        }

        //[HttpPost]
        //[ActionName("Index")]
        //public IActionResult IndexPost(int rows = 2, int cols = 2)
        //{
        //    ViewData["akcja"] = ControllerContext.ActionDescriptor.ActionName;
        //    ViewData["kontroler"] = ControllerContext.ActionDescriptor.ControllerName;
        //    ViewBag.rows = rows;
        //    ViewBag.cols = cols;
        //    ViewBag.html = GenerTab(rows, cols);
        //    return View();
        //}

        private string GenerTab(int rows, int cols) {
            StringBuilder sb = new StringBuilder();
            sb.Append("<table class='table'>");
            for (int i = 1; i <= rows; i++) {
                sb.Append("<tr>");
                for (int j = 1; j <= cols; j++) {
                    sb.Append("<td>" + (i * j) + "</td>");
                }
                sb.Append("</tr>");
            }

            return sb.Append("</table>").ToString();
        }
    }
}
