﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NotifyMe.Pages
{
    public class DemoModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {

        }
    }
}
