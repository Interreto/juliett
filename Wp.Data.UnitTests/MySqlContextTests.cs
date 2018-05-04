using System;
using System.Linq;
using Wp.Data.MySql;
using Xunit;

namespace Wp.Data.UnitTests
{
    public class MySqlContextTests
    {
        private readonly string cs = "server=localhost;port=3306;user=root;password=1;database=www";

        [Fact]
        public void MySqlContext_Comments()
        {
            using (var context = new MySqlContext(cs))
            {
                Assert.True(context.Comments.Any());
            }
        }

        [Fact]
        public void MySqlContext_Options()
        {
            using (var context = new MySqlContext(cs))
            {
                Assert.True(context.Options.Any());
            }
        }

        [Fact]
        public void MySqlContext_Posts()
        {
            using (var context = new MySqlContext(cs))
            {
                Assert.True(context.Posts.Any());
            }
        }

        [Fact]
        public void MySqlContext_Users()
        {
            using (var context = new MySqlContext(cs))
            {
                Assert.True(context.Users.Any());
            }
        }


    }
}
