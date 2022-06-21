using Microsoft.EntityFrameworkCore;
using PK_API.Models;

namespace PK_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Catalog> Catalogs { get; set; }
    }
}
