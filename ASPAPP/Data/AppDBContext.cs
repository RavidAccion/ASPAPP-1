using ASPAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPAPP.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        {

        }
        public DbSet<Category> categoryTab1 { get; set; }
    }
}
