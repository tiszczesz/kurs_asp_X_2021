using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class MyFormModel : PageModel
    {
        public void OnGet()
        {
            ViewData["get"] = "Z OnGet";
        }
        public void OnPost(){
            var a = Convert.ToInt32(Request.Form["a"]);
            var b = Convert.ToInt32(Request.Form["b"]);
            int wynik = a + b;
            ViewData["wynik"] = wynik;
            ViewData["post"] = "z OnPost";
        }
    }
}
