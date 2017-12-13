
using Microsoft.EntityFrameworkCore;

namespace SacramentMeetingApp.Models
{
    public class SacramentMeetingAppContext : DbContext
    {
        public SacramentMeetingAppContext (DbContextOptions<SacramentMeetingAppContext>  options): base(options)
        {
        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meeting>().ToTable("Meeting");
            modelBuilder.Entity<Speaker>().ToTable("Speaker");
            modelBuilder.Entity<Song>().ToTable("Song");
        }
    }
}
