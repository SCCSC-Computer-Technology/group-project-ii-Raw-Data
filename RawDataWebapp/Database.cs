using Microsoft.EntityFrameworkCore;
using RawDataWebapp.Models;
using Microsoft.AspNetCore.Identity;


namespace RawDataWebapp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<WNBAPlayer> WNBAPlayers { get; set; }
        public DbSet<NBAPlayer> NBAPlayers { get; set; }
        public DbSet<BaseballPlayer> BaseballPlayers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuring EF to use the "WNBA" table for the "WNBAPlayer" entity
            modelBuilder.Entity<WNBAPlayer>()
                .ToTable("WNBA");

            // Setting PlayerName as the primary key for the WNBAPlayer entity
            modelBuilder.Entity<WNBAPlayer>()
                .HasKey(p => p.PlayerName);
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().Property(u => u.Username).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<User>().Property(u => u.Password).IsRequired().HasMaxLength(256);

            modelBuilder.Entity<WNBAPlayer>()
         .Property(p => p.GamesPlayed).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.GamesStarted).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.Minutes).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.Points).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.OffensiveRebounds).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.DefensiveRebounds).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.TotalRebounds).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.Assist).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.Steals).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.Blocks).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.Turnovers).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.PersonalFouls).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.AssistToTurnovers).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.FieldGoalsMade).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.FieldGoalsAttempted).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.FieldGoalPercentage).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.ThreePointsMade).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.ThreePointsAttempted).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.ThreePointsPercentage).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.FreeThrowsMade).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.FreeThrowAttempted).HasColumnType("float");
            modelBuilder.Entity<WNBAPlayer>()
                .Property(p => p.FreeThrowPercentage).HasColumnType("float");
           
            modelBuilder.Entity<NBAPlayer>()
                .ToTable("NBA");
            modelBuilder.Entity<NBAPlayer>()
                .HasKey(p => p.PlayerName);

            modelBuilder.Entity<NBAPlayer>()
        .Property(p => p.GamesPlayed).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.GamesStarted).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.Minutes).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.Points).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.OffensiveRebounds).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.DefensiveRebounds).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.TotalRebounds).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.Assist).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.Steals).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.Blocks).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.Turnovers).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.PersonalFouls).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.AssistToTurnovers).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.FieldGoalsMade).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.FieldGoalsAttempted).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.FieldGoalPercentage).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.ThreePointsMade).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.ThreePointsAttempted).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.ThreePointsPercentage).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.FreeThrowsMade).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.FreeThrowAttempted).HasColumnType("float");
            modelBuilder.Entity<NBAPlayer>()
                .Property(p => p.FreeThrowPercentage).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().ToTable("Baseball");
            modelBuilder.Entity<BaseballPlayer>().HasKey(p => p.PlayerName);
            
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.GamesPlayed).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.AtBats).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.Runs).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.Hits).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.Doubles).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.Triples).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.HomeRuns).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.RunsBattedIn).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.TotalBases).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.Walks).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.Strikeouts).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.StolenBases).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.BattingAverage).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.OnBasePercentage).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.SluggingPercentage).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.OPS).HasColumnType("float");
            modelBuilder.Entity<BaseballPlayer>().Property(p => p.WAR).HasColumnType("float");
            
        }


    }
}
