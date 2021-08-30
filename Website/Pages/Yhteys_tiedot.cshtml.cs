using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Pages
{
    public class YhteysTiedotModel : PageModel
    {
        private readonly ILogger<YhteysTiedotModel> _logger;

        public YhteysTiedotModel(ILogger<YhteysTiedotModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
