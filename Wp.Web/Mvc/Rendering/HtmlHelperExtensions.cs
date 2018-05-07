using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Text;
using Wp.Web;

namespace Microsoft.AspNetCore.Mvc.Rendering
{
    public static class HtmlHelperExtensions
    {
        public static IWpHtmlHelper Wp(this IHtmlHelper htmlHelper)
        {
            return null;
        }

        public static IHtmlContent GetHeader(this IHtmlHelper htmlHelper, string name = null)
        {
            return htmlHelper.Partial(string.IsNullOrEmpty(name) ? "header.cshtml" : $"header-{name}.cshtml");
        }

        public static IHtmlContent GetFooter(this IHtmlHelper htmlHelper, string name = null)
        {
            return htmlHelper.Partial(string.IsNullOrEmpty(name) ? "footer.cshtml" : $"footer-{name}.cshtml");
        }

        public static IHtmlContent GetSidebar(this IHtmlHelper htmlHelper, string name = null)
        {
            return htmlHelper.Partial(string.IsNullOrEmpty(name) ? "sidebar.cshtml" : $"sidebar-{name}.cshtml");
        }
    }
}
