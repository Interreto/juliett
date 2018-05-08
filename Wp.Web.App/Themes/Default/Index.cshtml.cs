using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Wp.Data;
using Wp.Web.Pages;

namespace Wp.Web.App.Pages
{
    public class IndexModel : WpPageIndex
    {
        public IndexModel(WpContext context) 
            : base(context)
        {
            var s = string.Empty;
        }

        public void OnGet()
        {

        }
    }
}
