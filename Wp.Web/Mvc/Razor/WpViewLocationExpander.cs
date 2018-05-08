using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.AspNetCore.Mvc.Razor
{
    public class WpViewLocationExpander : IViewLocationExpander
    {
        private const string THEME_KEY = "Default";

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            string theme = null;

            if (context.Values.TryGetValue(THEME_KEY, out theme))
            {
                viewLocations = new[] {
                    $"/Themes/{theme}/{{1}}/{{0}}.cshtml",
                    $"/Themes/{theme}/Shared/{{0}}.cshtml",
                }
                .Concat(viewLocations);
            }

            return viewLocations;
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            context.Values[THEME_KEY] = "Default";
        }
    }
}
