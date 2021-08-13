using XamarinShop.Web.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace XamarinShop.Web.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Product>  Products{ get; set; }
        public DbSet<Country>  countries { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base (options)

        { 
                    
        }
    }
}
