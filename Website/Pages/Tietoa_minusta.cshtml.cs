using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Pages
{
    public class TietoaMinustaModel : PageModel
    {
        private readonly ILogger<TietoaMinustaModel> _logger;

        public TietoaMinustaModel(ILogger<TietoaMinustaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
