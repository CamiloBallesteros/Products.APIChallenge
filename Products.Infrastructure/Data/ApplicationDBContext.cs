using Microsoft.EntityFrameworkCore;
using Products.Core.Entities;

namespace Products.Infrastructure.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { }

        public DbSet<ProductsEntity> Products { get; set; }
    }
}
