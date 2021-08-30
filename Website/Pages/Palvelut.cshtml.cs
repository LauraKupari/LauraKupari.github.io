using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Pages
{
    public class PalvelutModel : PageModel
    {
        private readonly ILogger<PalvelutModel> _logger;

        public PalvelutModel(ILogger<PalvelutModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
