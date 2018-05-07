using Microsoft.EntityFrameworkCore;

namespace Wp.Data.MySql
{
    public partial class MySqlContext : WpContext
    {
        private readonly string _connectionString;

        public MySqlContext(string connectionString)
            : this()
        {
            _connectionString = connectionString;
        }

        public MySqlContext()
        {

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
