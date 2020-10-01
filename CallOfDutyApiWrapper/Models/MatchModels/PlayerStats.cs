using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace CallOfDutyApiWrapper.Models
{
    public class PlayerStats
    {
        public decimal medalXp { get; set; }
        public decimal objectiveLastStandKill { get; set; }
        public decimal matchXp { get; set; }
        public decimal kills { get; set; }
        public decimal scoreXp { get; set; }
        public decimal wallBangs { get; set; }
        public decimal score { get; set; }
        public decimal totalXp { get; set; }
        public decimal headshots { get; set; }
        public decimal assists { get; set; }
        public decimal challengeXp { get; set; }
        public decimal rank { get; set; }
        public decimal scorePerMinute { get; set; }
        public decimal distanceTraveled { get; set; }
        public decimal teamSurvivalTime { get; set; }
        public decimal deaths { get; set; }
        public decimal kdRatio { get; set; }
        public decimal objectiveBrDownEnemyCircle1 { get; set; }
        public decimal objectiveBrMissionPickupTablet { get; set; }
        public decimal bonusXp { get; set; }
        public decimal gulagDeaths { get; set; }
        public decimal timePlayed { get; set; }
        public decimal executions { get; set; }
        public decimal gulagKills { get; set; }
        public decimal nearmisses { get; private set; }
        public decimal objectiveBrCacheOpen { get; private set; }
        public decimal percentTimeMoving { get; set; }
        public decimal miscXp { get; set; }
        public decimal longestStreak { get; set; }
        public decimal teamPlacement { get; set; }
        public decimal damageDone { get; set; }
        public decimal damageTaken { get; set; }
    }
}
