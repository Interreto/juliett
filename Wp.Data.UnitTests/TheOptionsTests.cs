using System;
using System.Linq;
using Xunit;

namespace Wp.Data.UnitTests
{
    /// <summary>
    /// The integration test with a preset WordPress data
    /// </summary>
    public class TheOptionsTests
    {
        [Fact]
        public void TheOptions()
        {
            using (var context = WpContextHelper.CreateDbContext())
            {
                var options = new TheOptions(context);

                Assert.True(options.Any());
            }
        }
    }
}
