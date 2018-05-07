using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Wp.Data;

namespace Wp.Web.Pages
{
    public abstract class WpPage : PageModel
    {
        WpContext _context;

        public WpPage(WpContext context)
        {
            _context = context;
        }
    }
}
