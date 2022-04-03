using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AspNetCoreMVC.Views.Shared
{
    public class _NavBar : PageModel
    {
        private readonly ILogger<_NavBar> _logger;

        public _NavBar(ILogger<_NavBar> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
