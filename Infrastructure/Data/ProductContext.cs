using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ConsoleApp1.Data
{
    internal class ProductContext : DbContext
    {

        private readonly string _connectionString = "Data Source=DESKTOP-AEFKJ3D;Initial Catalog=product_db ;Integrated Security=True;Trust Server Certificate=True";

        public DbSet<Product> Products { get; set; }


        private readonly ILoggerFactory loggerFactory = LoggerFactory.Create(
            builder =>
            {
                builder.AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Warning)
                .AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information)
                .AddConsole();
            }
            );

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);
            optionsBuilder.UseLoggerFactory(loggerFactory);
        }

    }
}
