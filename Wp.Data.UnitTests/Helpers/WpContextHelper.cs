using Wp.Data.MySql;

namespace Wp.Data.UnitTests
{
    public static class WpContextHelper
    {
        public static string cs = "server=localhost;port=3306;user=root;password=1;database=www;Convert Zero Datetime=true";

        public static WpContext CreateDbContext()
        {
            return new MySqlContext(cs);
        }
    }
}
