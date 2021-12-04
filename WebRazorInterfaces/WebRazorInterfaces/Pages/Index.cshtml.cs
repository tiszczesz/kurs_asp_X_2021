using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRazorInterfaces.Abstraction;
using WebRazorInterfaces.Implements;
using WebRazorInterfaces.Models;

namespace WebRazorInterfaces.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ISaveable _mySaveable;

        [BindProperty]
        public Quote MyList { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _mySaveable = new RamSave();
            MyList = new Quote(_mySaveable.Load());
        }

        public void OnGet() {
           
        }
    }
}
