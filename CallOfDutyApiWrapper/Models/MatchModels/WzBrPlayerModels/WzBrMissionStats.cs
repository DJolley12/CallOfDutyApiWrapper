using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels
{
    public class WzBrMissionStats
    {
        public int MissionsComplete { get; set; }
        public int TotalMissionXpEarned { get; set; }
        public int TotalMissionWeaponXpEarned { get; set; }
        public string[] MissionStatsByType { get; set; }
    }
}
