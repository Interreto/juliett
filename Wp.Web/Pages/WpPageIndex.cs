using System;
using System.Collections.Generic;
using System.Text;
using Wp.Data;

namespace Wp.Web.Pages
{
    public abstract class WpPageIndex : WpPage
    {
        public WpPageIndex(WpContext context) : base(context)
        {
        }
    }
}
