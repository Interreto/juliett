using System;
using System.Linq;
using Wp.Data.Entities;
using Xunit;

namespace Wp.Data.UnitTests
{
    public class TheMetaTests
    {
        [Fact]
        public void TheMeta_WpCommentMeta()
        {
            using (var context = WpContextHelper.CreateDbContext())
            {
                var meta = new TheMeta<WpCommentMeta>(context).Get(1);

                Assert.False(meta.Any());
            }
        }

        [Fact]
        public void TheMeta_WpPostMeta()
        {
            using (var context = WpContextHelper.CreateDbContext())
            {
                var meta = new TheMeta<WpPostMeta>(context).Get(1);

                Assert.True(meta.Any());
            }
        }

        [Fact]
        public void TheMeta_WpTermMeta()
        {
            using (var context = WpContextHelper.CreateDbContext())
            {
                var meta = new TheMeta<WpTermMeta>(context).Get(1);

                Assert.False(meta.Any());
            }
        }

        [Fact]
        public void TheMeta_WpUserMeta()
        {
            using (var context = WpContextHelper.CreateDbContext())
            {
                var meta = new TheMeta<WpUserMeta>(context).Get(1);

                Assert.True(meta.Any());
            }
        }
    }
}
