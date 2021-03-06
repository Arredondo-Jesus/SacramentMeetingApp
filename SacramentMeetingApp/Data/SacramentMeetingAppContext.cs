﻿
using Microsoft.EntityFrameworkCore;

namespace SacramentMeetingApp.Models
{
    public class SacramentMeetingAppContext : DbContext
    {
        public SacramentMeetingAppContext (DbContextOptions<SacramentMeetingAppContext>  options): base(options)
        {
        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meeting>().ToTable("Meeting");
            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<Song>().ToTable("Song");

            modelBuilder.Entity<Meeting>()
            .HasKey(t => t.meetingID);

             modelBuilder.Entity<Meeting>()
            .HasMany(t => t.songs)
            .WithOne(t => t.Meeting);

            modelBuilder.Entity<Meeting>()
            .HasMany(t => t.members)
            .WithOne(t => t.Meeting);

        }
    }
}
