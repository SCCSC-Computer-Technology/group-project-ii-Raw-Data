using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RawDataWebapp.Models
{

    public class WNBAPlayer
    {

        
        public string PlayerName { get; set; }

        
        public float? GamesPlayed { get; set; }
        public float? GamesStarted { get; set; }
        public float? Minutes { get; set; }
        public float? Points { get; set; }
        public float? OffensiveRebounds { get; set; }
        public float? DefensiveRebounds { get; set; }
        public float? TotalRebounds { get; set; }
        public float? Assist { get; set; }
        public float? Steals { get; set; }
        public float? Blocks { get; set; }
        public float? Turnovers { get; set; }
        public float? PersonalFouls { get; set; }
        public float? AssistToTurnovers { get; set; }
        public float? FieldGoalsMade { get; set; }
        public float? FieldGoalsAttempted { get; set; }
        public float? FieldGoalPercentage { get; set; }
        public float? ThreePointsMade { get; set; }
        public float? ThreePointsAttempted { get; set; }
        public float? ThreePointsPercentage { get; set; }
        public float? FreeThrowsMade { get; set; }
        public float? FreeThrowAttempted { get; set; }
        public float? FreeThrowPercentage { get; set; }

        
        public string Position { get; set; }
        public string TeamName { get; set; }
        
    }
}