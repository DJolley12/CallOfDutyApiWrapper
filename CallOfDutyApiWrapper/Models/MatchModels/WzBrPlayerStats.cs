using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace CallOfDutyApiWrapper.Models
{
    public class WzBrPlayerStats
    {
        public int Kills { get; set; }
        public int MedalXp { get; set; }
        public int ObjectiveLastStandKill { get; set; }
        public int MatchXp { get; set; }
        public int ScoreXp { get; set; }
        public int WallBangs { get; set; }
        public int Score { get; set; }
        public int TotalXp { get; set; }
        public int Headshots { get; set; }
        public int Assists { get; set; }
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
        public int Nearmisses { get; private set; }
        public int ObjectiveBrCacheOpen { get; private set; }
        public decimal PercentTimeMoving { get; set; }
        public int MiscXp { get; set; }
        public int LongestStreak { get; set; }
        public int TeamPlacement { get; set; }
        public int DamageDone { get; set; }
        public int DamageTaken { get; set; }

        public WzBrPlayerStats(JToken jToken)
        {
            Int32.TryParse(jToken["kills"].ToString(), out int kills);
            Kills = kills;

            Int32.TryParse(jToken["medalXp"].ToString(), out int medalXp);
            MedalXp = medalXp;

            Int32.TryParse(jToken["objectiveLastStandKill"].ToString(), out int objectiveLastStandKill);
            ObjectiveLastStandKill = objectiveLastStandKill;

            Int32.TryParse(jToken["matchXp"].ToString(), out int matchXp);
            MatchXp = matchXp;

            Int32.TryParse(jToken["scoreXp"].ToString(), out int scoreXp);
            ScoreXp = scoreXp;

            Int32.TryParse(jToken["wallBangs"].ToString(), out int wallBangs);
            WallBangs = wallBangs;

            Int32.TryParse(jToken["score"].ToString(), out int score);
            Score = score;

            Int32.TryParse(jToken["totalXp"].ToString(), out int totalXp);
            TotalXp = totalXp;

            Int32.TryParse(jToken["headshots"].ToString(), out int headshots);
            Headshots = headshots;

            Int32.TryParse(jToken["assists"].ToString(), out int assists);
            Assists = assists;

            Int32.TryParse(jToken["challengeXp"].ToString(), out int challengeXp);
            ChallengeXp = challengeXp;

            Int32.TryParse(jToken["rank"].ToString(), out int rank);
            Rank = rank;

            Int32.TryParse(jToken["scorePerMinute"].ToString(), out int scorePerMinute);
            ScorePerMinute = scorePerMinute;

            Int32.TryParse(jToken["distanceTraveled"].ToString(), out int distanceTraveled);
            DistanceTraveled = distanceTraveled;

            Int32.TryParse(jToken["teamSurvivalTime"].ToString(), out int teamSurvivalTime);
            TeamSurvivalTime = teamSurvivalTime;

            Int32.TryParse(jToken["deaths"].ToString(), out int deaths);
            Deaths = deaths;

            decimal.TryParse(jToken["kdRatio"].ToString(), out decimal kdRatio);
            KdRatio = kdRatio;

            Int32.TryParse(jToken["objectiveBrDownEnemyCircle1"].ToString(), out int objectiveBrDownEnemyCircle1);
            ObjectiveBrDownEnemyCircle1 = objectiveBrDownEnemyCircle1;

            Int32.TryParse(jToken["bonusXp"].ToString(), out int bonusXp);
            BonusXp = bonusXp;

            Int32.TryParse(jToken["gulagDeaths"].ToString(), out int gulagDeaths);
            GulagDeaths = gulagDeaths;

            Int32.TryParse(jToken["timePlayed"].ToString(), out int timePlayed);
            TimePlayed = timePlayed;

            Int32.TryParse(jToken["nearmisses"].ToString(), out int nearmisses);
            Nearmisses = nearmisses;

            Int32.TryParse(jToken["objectiveBrCacheOpen"].ToString(), out int objectiveBrCacheOpen);
            ObjectiveBrCacheOpen = objectiveBrCacheOpen;

            Int32.TryParse(jToken["percentTimeMoving"].ToString(), out int percentTimeMoving);
            PercentTimeMoving = percentTimeMoving;

            Int32.TryParse(jToken["miscXp"].ToString(), out int miscXp);
            MiscXp = miscXp;

            Int32.TryParse(jToken["longestStreak"].ToString(), out int longestStreak);
            LongestStreak = longestStreak;

            Int32.TryParse(jToken["teamPlacement"].ToString(), out int teamPlacement);
            TeamPlacement = teamPlacement;

            Int32.TryParse(jToken["damageDone"].ToString(), out int damageDone);
            DamageDone = damageDone;

            Int32.TryParse(jToken["damageTaken"].ToString(), out int damageTaken);
            DamageTaken = damageTaken;
        }
    }
}
