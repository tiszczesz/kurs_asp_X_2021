using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw1
{
    public class IndexModel : PageModel
    {
        public List<Customer> Customers { get; set; }
       

        public void OnGet()
        {
        }
    }
}
