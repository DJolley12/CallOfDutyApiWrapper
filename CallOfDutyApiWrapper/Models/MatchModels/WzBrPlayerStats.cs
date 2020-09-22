using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDutyApiWrapper.Models
{
    public class WzBrPlayerStats
    {
        public int Kills { get; set; }
        public int MedalXp { get; set; }
        public int MatchXp { get; set; }
        public int ScoreXp { get; set; }
        public int Score { get; set; }
        public int TotalXp { get; set; }
        public int Headshots { get; set; }
        public int assists { get; set; }
        public int ChallengeXp { get; set; }
        public int Rank { get; set; }
        public decimal ScorePerMinute { get; set; }
        public int DistanceTraveled { get; set; }
        public int TeamSurvivalTime { get; set; }
        public int Deaths { get; set; }
        public decimal KdRatio { get; set; }
        public int ObjectiveBrDownEnemyCircle1 { get; set; }
        public int ObjectiveBrMissionPickupTablet { get; set; }
        public int BonusXp { get; set; }
        public int GulagDeaths { get; set; }
        public int TimePlayed { get; set; }
        public int Executions { get; set; }
        public int GulagKills { get; set; }
        public decimal PercentTimeMoving { get; set; }
        public int MiscXp { get; set; }
        public int LongestStreak { get; set; }
        public int TeamPlacement { get; set; }
        public int DamageDone { get; set; }
        public int DamageTaken { get; set; }
    }
}
