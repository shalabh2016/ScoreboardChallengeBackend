using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ScoreboardChallenge.Model;

namespace ScoreboardChallenge.Data
{
    public class PlayerPointDbContext : DbContext
    {
        public DbSet<PlayerPointModel> PlayerPoint { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=playerpointdb.db");
    }

}