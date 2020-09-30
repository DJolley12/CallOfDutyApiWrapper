using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace CallOfDutyApiWrapper.Models
{
    public class PlayerStats
    {
        public int medalXp { get; set; }
        public int objectiveLastStandKill { get; set; }
        public int matchXp { get; set; }
        public int kills { get; set; }
        public int scoreXp { get; set; }
        public int wallBangs { get; set; }
        public int score { get; set; }
        public int totalXp { get; set; }
        public int headshots { get; set; }
        public int assists { get; set; }
        public int challengeXp { get; set; }
        public int rank { get; set; }
        public decimal? scorePerMinute { get; set; }
        public int distanceTraveled { get; set; }
        public int teamSurvivalTime { get; set; }
        public int deaths { get; set; }
        public decimal? kdRatio { get; set; }
        public int objectiveBrDownEnemyCircle1 { get; set; }
        public int objectiveBrMissionPickupTablet { get; set; }
        public int bonusXp { get; set; }
        public int gulagDeaths { get; set; }
        public int timePlayed { get; set; }
        public int executions { get; set; }
        public int gulagKills { get; set; }
        public int nearmisses { get; private set; }
        public int objectiveBrCacheOpen { get; private set; }
        public decimal percentTimeMoving { get; set; }
        public int miscXp { get; set; }
        public int longestStreak { get; set; }
        public int teamPlacement { get; set; }
        public int damageDone { get; set; }
        public int damageTaken { get; set; }
    }
}
