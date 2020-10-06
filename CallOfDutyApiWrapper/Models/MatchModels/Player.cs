using CallOfDutyApiWrapper.Models.MatchModels;
using CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDutyApiWrapper.Models
{
    public class Player
    {
        public string team { get; set; }
        public decimal rank { get; set; }
        public Awards awards { get; set; }
        public string username { get; set; }
        public ulong uno { get; set; }
        public string clantang { get; set; }
        public MissionStats brMissionStats { get; set; }
        public List<Loadout> loadout { get; set; }
    }
}
