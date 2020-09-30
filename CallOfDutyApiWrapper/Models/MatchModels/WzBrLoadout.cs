﻿using CallOfDutyApiWrapper.Models.MatchModels;
using CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels.WzBrLoadoutModels;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace CallOfDutyApiWrapper.Models
{
    public class WzBrLoadout
    {
        public WzBrPrimaryWeapon PrimaryWeapon { get; set; }
        public WzBrSecondaryWeapon SecondaryWeapon { get; set; }
        public List<WzBrPerk> Perks { get; set; }
        public List<WzBrPerk> ExtraPerks { get; set; }
        public List<WzBrKillstreak> Killstreaks { get; set; }
        public WzBrThrown Tactical { get; set; }
        public WzBrThrown Lethal { get; set; }

        public WzBrLoadout(JToken jToken)
        {
            var primaryWeapon = jToken["primaryWeapon"];
            PrimaryWeapon = new WzBrPrimaryWeapon(primaryWeapon);
        }
    }
}