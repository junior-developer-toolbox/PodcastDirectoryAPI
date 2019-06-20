using System;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using PodcastDirectoryAPI.Domain;

namespace PodcastDirectoryAPI.Data
{
    public class PodcastDirectoryAPIContext : DbContext
    {
        public PodcastDirectoryAPIContext(DbContextOptions<PodcastDirectoryAPIContext> options)
        : base(options)
        { }

        public DbSet<PodcastDetails> PodcastDetails { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<ContactInfo> ContactInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}
