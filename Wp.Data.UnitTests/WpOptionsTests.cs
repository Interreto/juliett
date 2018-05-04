using System;
using System.Linq;
using Xunit;

namespace Wp.Data.UnitTests
{
    /// <summary>
    /// The integration test with a preset WordPress data
    /// </summary>
    public class WpOptionsTests
    {
        [Fact]
        public void MySqlContext_Comments()
        {
            using (var context = WpContextHelper.CreateDbContext())
            {
                var options = new TheOptions(context);

                Assert.True(options.Any());
            }
        }
    }
}
