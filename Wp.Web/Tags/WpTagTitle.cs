using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Threading.Tasks;
using Wp.Data;

namespace Wp.Web.Tags
{
    [HtmlTargetElement("wp-title")]
    public class WpTagTitle : WpTag
    {
        WpContext _context;

        string _blogname;

        public WpTagTitle(WpContext context)
        {
            _context = context;

            _blogname = new TheOptions(_context)["blogname"];
        }

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            return base.ProcessAsync(context, output);
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "title";
            output.Content.SetHtmlContent(_blogname);
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}
