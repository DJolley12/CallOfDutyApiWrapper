﻿using CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDutyApiWrapper.Models
{
    public class Player
    {
        public string team { get; set; }
        public int rank { get; set; }
        public string[] awards { get; set; }
        public string username { get; set; }
        public ulong uno { get; set; }
        public string clantang { get; set; }
        public MissionStats brMissionStats { get; set; }
        public Loadout loadout { get; set; }
    }
}
