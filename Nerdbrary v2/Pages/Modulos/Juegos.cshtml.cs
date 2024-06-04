using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Nerdbrary_v2.Pages.Modulos
{
    public class Juegos : PageModel
    {
        private readonly ILogger<Juegos> _logger;

        public Juegos(ILogger<Juegos> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}