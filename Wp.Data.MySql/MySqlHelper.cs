using Microsoft.Extensions.Configuration;
using System.Linq;

namespace Wp.Data.MySql
{
    public static class MySqlHelper
    {
        public static string BuildConnectionString(this IConfiguration configuration)
        {
            var host = WpConfig.Db.Host.Split(":");
            var port = "3306";

            return $"server={host.First()};port={port};user={WpConfig.Db.User};password={WpConfig.Db.Password};database={WpConfig.Db.Name}";
        }
    }
}
