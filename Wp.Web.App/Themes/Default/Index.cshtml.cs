using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Wp.Data;
using Wp.Data.Entities;
using Wp.Web.Pages;

namespace Wp.Web.App.Pages
{
    public class IndexModel : WpPageIndex
    {
        public IReadOnlyCollection<WpPosts> Posts { get; } 

        public IndexModel(WpContext context) 
            : base(context)
        {
            var s = string.Empty;

            Posts = context.Posts.ToArray();
        }

        public void OnGet()
        {

        }
    }
}
