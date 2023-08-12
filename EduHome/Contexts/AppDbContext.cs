using EduHome.Models;
using Microsoft.EntityFrameworkCore;

namespace EduHome.Contexts
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        }

        public DbSet<Slider> Sliders { get; set; } = null!;
		public DbSet<Events> Events { get; set; } = null!;
		public DbSet<Speakers> Speakers { get; set; } = null!;
		public DbSet<SpeakersEvent> SpeakersEvents { get; set; } = null!;

      

    }
}
