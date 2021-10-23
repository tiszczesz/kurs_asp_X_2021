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
        // [BindProperty]
        public List<Customer> Customers { get; set; }
       public IndexModel()
       {
           Customers = new List<Customer>{
               new Customer{FirstName = "Antoni",LastName = "Wołecki",Age=23},
               new Customer{FirstName = "Monika",LastName = "Gruszka",Age=22},
               new Customer{FirstName = "Tomasz",LastName = "Bomasz",Age=33},
               new Customer{FirstName = "Roman",LastName = "Gałecki",Age=31},
               new Customer{FirstName = "Grażyna",LastName = "Sprężyna",Age=54}
           };
       }

        public void OnGet()
        {
        }
    }
}
