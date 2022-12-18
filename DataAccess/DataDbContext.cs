using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccess
{
    public class DataDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Server=localhost;Database=NeEkersen;Port=5432;User Id=postgres;Password=676401");

        }

        public DbSet<Activity> Activities { get; set; }    

      
    }
}