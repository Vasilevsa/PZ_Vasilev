using Microsoft.EntityFrameworkCore;
using Web_Service.Models;

namespace Client_WPF.Models
{
    public partial class HoteldbContext : DbContext
    {
        public HoteldbContext()
        {
        }

        public HoteldbContext(DbContextOptions<HoteldbContext> options) : base(options)
        {
        }

        public virtual DbSet<HotelInfo> Hotels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var current_dir = new System.IO.DirectoryInfo(System.IO.Directory.GetCurrentDirectory());
                var application_dir = current_dir.Parent.Parent.Parent.Parent.FullName;
                string db_path = "Data Source=" + application_dir + "\\Web Service" + "\\Hotels.db";

                optionsBuilder.UseSqlite(db_path);
            }
        }

    }
}