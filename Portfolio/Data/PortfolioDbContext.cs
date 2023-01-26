using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Data
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions options) : base(options) 
        {   

        }

        public DbSet<Portfolio_Data> Portfolio_Data { get; set; }
        public DbSet<Experience> Experience { get; set; }
    }
}
