using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wp.Web.Tags
{
    [HtmlTargetElement("wp-head")]
    public class WpTagHead : WpTag
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.SuppressOutput();
        }
    }
}
