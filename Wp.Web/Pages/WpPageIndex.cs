using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Wp.Data;
using Wp.Data.Entities;

namespace Wp.Web.Pages
{
    public abstract class WpPageIndex : WpPage, IEnumerable<WpPosts>
    {
        private readonly IReadOnlyCollection<WpPosts> _posts;

        public WpPageIndex(WpContext context) : base(context)
        {
            _posts = Db.Posts
                .Where(x => x.PostType == WpPostType.Post)
                .Where(x => x.PostStatus == WpPostStatus.Publish)
                .OrderByDescending(x => x.PostDate)
                .Take(10)
                .ToArray();
        }

        public IEnumerator<WpPosts> GetEnumerator()
        {
            return _posts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _posts.GetEnumerator();
        }
    }
}
