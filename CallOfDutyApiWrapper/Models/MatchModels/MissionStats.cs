using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels
{
    public class MissionStats
    {
        public int missionsComplete { get; set; }
        public int totalMissionXpEarned { get; set; }
        public int totalMissionWeaponXpEarned { get; set; }
        public string[] missionStatsByType { get; set; }
    }
}
