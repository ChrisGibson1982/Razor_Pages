using Microsoft.EntityFrameworkCore;

namespace Razor_Pages
{
    public class AppDbContext :   DbContext
    {
            public AppDbContext(DbContextOptions options) 
                : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

    }
}