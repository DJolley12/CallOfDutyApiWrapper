using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDutyApiWrapper.Models
{
    public class Player
    {
        public string Team { get; set; }
        public int Rank { get; set; }
        public string[] Awards { get; set; }
        public string Username { get; set; }
        public string[] KillstreakUsage{ get; set; }
    }
}
