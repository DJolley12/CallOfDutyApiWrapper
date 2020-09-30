using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels
{
    public class WzBrMissionStats
    {
        public int MissionsComplete { get; set; }
        public int TotalMissionXpEarned { get; set; }
        public int TotalMissionWeaponXpEarned { get; set; }
        public string[] MissionStatsByType { get; set; }

        public WzBrMissionStats(JToken jToken)
        {
            Int32.TryParse(jToken["missionsComplete"].ToString(), out int missionsComplete);
            MissionsComplete = missionsComplete;

            Int32.TryParse(jToken["totalMissionXpEarned"].ToString(), out int totalMissionXpEarned);
            TotalMissionWeaponXpEarned = totalMissionXpEarned;

            MissionStatsByType = jToken.ToObject<string[]>();
        }
    }
}
