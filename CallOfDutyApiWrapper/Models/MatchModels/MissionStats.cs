using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels
{
    public class MissionStats
    {
        public decimal missionsComplete { get; set; }
        public decimal totalMissionXpEarned { get; set; }
        public decimal totalMissionWeaponXpEarned { get; set; }
        public MissionStatsByType missionStatsByType { get; set; }
    }
}
