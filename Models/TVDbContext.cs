using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace TVShowProject.Models
{
    public class TVDbContext : DbContext
    {
        public TVDbContext (DbContextOptions<TVDbContext> options)
            : base(options)
        {

        }    
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShowCast>()
                .HasKey(e => new {e.ShowID, e.MemberID});
        }    

        public DbSet<TVShowProject.Models.Show> Shows {get; set;}
        public DbSet<TVShowProject.Models.Cast> Cast {get; set;}
        public DbSet<TVShowProject.Models.ShowCast> ShowCast {get; set;}

    }
}