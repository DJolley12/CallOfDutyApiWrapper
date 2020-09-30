using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace CallOfDutyApiWrapper.Models
{
    public class PlayerStats
    {
        public int? Kills { get; set; }
        public int? MedalXp { get; set; }
        public int? ObjectiveLastStandKill { get; set; }
        public int? MatchXp { get; set; }
        public int? ScoreXp { get; set; }
        public int? WallBangs { get; set; }
        public int? Score { get; set; }
        public int? TotalXp { get; set; }
        public int? Headshots { get; set; }
        public int? Assists { get; set; }
        public int? ChallengeXp { get; set; }
        public int? Rank { get; set; }
        public decimal? ScorePerMinute { get; set; }
        public int? DistanceTraveled { get; set; }
        public int? TeamSurvivalTime { get; set; }
        public int? Deaths { get; set; }
        public decimal? KdRatio { get; set; }
        public int? ObjectiveBrDownEnemyCircle1 { get; set; }
        public int? ObjectiveBrMissionPickupTablet { get; set; }
        public int? BonusXp { get; set; }
        public int? GulagDeaths { get; set; }
        public int? TimePlayed { get; set; }
        public int? Executions { get; set; }
        public int? GulagKills { get; set; }
        public int? Nearmisses { get; private set; }
        public int? ObjectiveBrCacheOpen { get; private set; }
        public decimal? PercentTimeMoving { get; set; }
        public int? MiscXp { get; set; }
        public int? LongestStreak { get; set; }
        public int? TeamPlacement { get; set; }
        public int? DamageDone { get; set; }
        public int? DamageTaken { get; set; }

        public PlayerStats(JToken jToken)
        {
            Kills = jToken.Value<int?>("kills");
            MedalXp = jToken.Value<int?>("medalXp");
            ObjectiveLastStandKill = jToken.Value<int?>("objectiveLastStandKill");
            MatchXp = jToken.Value<int?>("matchXp");
            ScoreXp = jToken.Value<int?>("scoreXp");
            WallBangs = jToken.Value<int?>("wallBangs");
            Score = jToken.Value<int?>("score");
            TotalXp = jToken.Value<int?>("totalXp");
            Headshots = jToken.Value<int?>("headshots"); ;
            Assists = jToken.Value<int?>("assists");
            ChallengeXp = jToken.Value<int?>("challengeXp"); ;
            Rank = jToken.Value<int?>("rank");
            ScorePerMinute = jToken.Value<decimal?>("scorePerMinute");
            DistanceTraveled = jToken.Value<int?>("distanceTraveled");
            TeamSurvivalTime = jToken.Value<int?>("teamSurvivalTime");
            Deaths = jToken.Value<int?>("deaths");
            KdRatio = jToken.Value<int?>("kdRatio");
            ObjectiveBrDownEnemyCircle1 = jToken.Value<int?>("objectiveBrDownEnemyCircle1");

            // Int32.TryParse(jToken["bonusXp"].ToString(), out int? bonusXp);
            // BonusXp = bonusXp;

            // Int32.TryParse(jToken["gulagDeaths"].ToString(), out int? gulagDeaths);
            // GulagDeaths = gulagDeaths;

            // Int32.TryParse(jToken["timePlayed"].ToString(), out int? timePlayed);
            // TimePlayed = timePlayed;

            // Int32.TryParse(jToken["nearmisses"].ToString(), out int? nearmisses);
            // Nearmisses = nearmisses;

            // Int32.TryParse(jToken["objectiveBrCacheOpen"].ToString(), out int? objectiveBrCacheOpen);
            // ObjectiveBrCacheOpen = objectiveBrCacheOpen;

            // Int32.TryParse(jToken["percentTimeMoving"].ToString(), out int? percentTimeMoving);
            // PercentTimeMoving = percentTimeMoving;

            // Int32.TryParse(jToken["miscXp"].ToString(), out int? miscXp);
            // MiscXp = miscXp;

            // Int32.TryParse(jToken["longestStreak"].ToString(), out int? longestStreak);
            // LongestStreak = longestStreak;

            // Int32.TryParse(jToken["teamPlacement"].ToString(), out int? teamPlacement);
            // TeamPlacement = teamPlacement;

            // Int32.TryParse(jToken["damageDone"].ToString(), out int? damageDone);
            // DamageDone = damageDone;

            // Int32.TryParse(jToken["damageTaken"].ToString(), out int? damageTaken);
            // DamageTaken = damageTaken;
        }
    }
}
