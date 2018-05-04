using System;
using System.Linq;
using Xunit;

namespace Wp.Data.UnitTests
{
    public class WpContextTests
    {
        [Fact]
        public void MySqlContext_Comments()
        {
            using (var context = WpContextHelper.CreateDbContext())
            {
                Assert.True(context.Comments.Any());
            }
        }

        [Fact]
        public void MySqlContext_Options()
        {
            using (var context = WpContextHelper.CreateDbContext())
            {
                Assert.True(context.Options.Any());
            }
        }

        [Fact]
        public void MySqlContext_Posts()
        {
            using (var context = WpContextHelper.CreateDbContext())
            {
                Assert.True(context.Posts.Any());
            }
        }

        [Fact]
        public void MySqlContext_Users()
        {
            using (var context = WpContextHelper.CreateDbContext())
            {
                Assert.True(context.Users.Any());
            }
        }
    }
}
