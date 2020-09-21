using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDutyApiWrapper.Models
{
    public class PlayerStats
    {
        public int Kills { get; set; }
        public int MedalXp { get; set; }
        public int MatchXp { get; set; }
        public int ScoreXp { get; set; }
        public decimal Accuracy { get; set; }
        public int ShotsLanded { get; set; }
    }
}
