using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace RawDataWebapp.Models
{
    public class BaseballPlayer
    {
        [Key]
        public string PlayerName { get; set; }
        public string Position { get; set; }
        public double GamesPlayed { get; set; }
        public double AtBats { get; set; }
        public double Runs { get; set; }
        public double Hits { get; set; }
        public double Doubles { get; set; }
        public double Triples { get; set; }
        public double HomeRuns { get; set; }
        public double RunsBattedIn { get; set; }
        public double TotalBases { get; set; }
        public double Walks { get; set; }
        public double Strikeouts { get; set; }
        public double StolenBases { get; set; }
        public double BattingAverage { get; set; }
        public double OnBasePercentage { get; set; }
        public double SluggingPercentage { get; set; }
        public double OPS { get; set; }
        public double WAR { get; set; }
        public string TeamName { get; set; }
        
    }
}
