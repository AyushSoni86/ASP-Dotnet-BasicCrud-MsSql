using Microsoft.EntityFrameworkCore;

namespace BasicCrud_MsSql.Models
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext> options) : base(options)
        {

        }

        public DbSet<Brand> Brands { get; set; }
    }
}
