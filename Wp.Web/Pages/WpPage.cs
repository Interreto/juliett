using Microsoft.AspNetCore.Mvc.RazorPages;
using Wp.Data;

namespace Wp.Web.Pages
{
    public abstract class WpPage : PageModel
    {
        protected WpContext Db { get; }

        public WpPage(WpContext context)
        {
            Db = context;
        }
    }
}
