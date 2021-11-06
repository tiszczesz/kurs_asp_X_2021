using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using RazorPagesUsers.Models;

namespace RazorPagesUsers.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger) {
            string fileName = "dane.txt";
            if (!System.IO.File.Exists(fileName))
            {
                FileRepository.SetConfigure(fileName);
            }
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
