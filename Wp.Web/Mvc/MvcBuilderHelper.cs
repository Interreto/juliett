using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Wp.Data;

namespace Wp.Web.Mvc
{
    public static class MvcBuilderHelper
    {
        public static IMvcBuilder AddWp(this IMvcBuilder builder, Func<IServiceProvider, WpContext> implementationFactory)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            builder
                .AddRazorPagesOptions(options =>
                {
                    options.RootDirectory = "/Themes/Default";
                });

            builder
                .Services
                .Configure<RazorViewEngineOptions>(options =>
                {
                    options.ViewLocationExpanders.Add(new WpViewLocationExpander());
                })
                .AddScoped<WpContext>(implementationFactory)
                
                ;

            return builder;
        }
    }
}
