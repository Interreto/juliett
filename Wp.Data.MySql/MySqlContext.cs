using Microsoft.EntityFrameworkCore;

namespace Wp.Data.MySql
{
    public partial class MySqlContext : WpContext
    {
        private readonly string _connectionString;

        public MySqlContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(_connectionString);
            }
        }
    }
}
