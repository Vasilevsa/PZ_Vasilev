using Microsoft.EntityFrameworkCore;

namespace Web_Service.Models
{
    public class HoteldbMainContext : DbContext
    {
        public HoteldbMainContext()
        {
        }

        public DbSet<HotelInfo> Hotels { get; set; }

        public HoteldbMainContext(DbContextOptions<HoteldbMainContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();           
        }
    }
}