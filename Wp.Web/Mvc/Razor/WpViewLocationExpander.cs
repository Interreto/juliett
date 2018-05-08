using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Mvc.Razor
{
    public class WpViewLocationExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            return new[] {
                $"/Themes/Default/{{1}}/{{0}}.cshtml",
            };
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            var values = context.Values;
        }
    }
}
