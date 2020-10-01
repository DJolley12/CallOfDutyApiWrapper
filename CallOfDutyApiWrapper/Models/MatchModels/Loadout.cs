using CallOfDutyApiWrapper.Models.MatchModels;
using CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels.WzBrLoadoutModels;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace CallOfDutyApiWrapper.Models
{
    public class Loadout
    {
        public Weapon primaryWeapon { get; set; }
        public Weapon secondaryWeapon { get; set; }
        public List<Perk> perks { get; set; }
        public List<Perk> extraPerks { get; set; }
        public List<Killstreak> killstreaks { get; set; }
        public Thrown tactical { get; set; }
        public Thrown lethal { get; set; }
    }
}