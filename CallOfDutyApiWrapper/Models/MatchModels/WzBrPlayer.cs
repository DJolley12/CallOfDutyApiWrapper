using CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDutyApiWrapper.Models
{
    public class WzBrPlayer
    {
        public string Team { get; set; }
        public int Rank { get; set; }
        public string[] Awards { get; set; }
        public string Username { get; set; }
        public ulong Uno { get; set; }
        public string Clantang { get; set; }
        public WzBrMissionStats BrMissionStats {get; set;}
    }
}
