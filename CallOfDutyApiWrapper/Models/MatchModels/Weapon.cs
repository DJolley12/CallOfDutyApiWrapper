using CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels.WzBrLoadoutModels.WzBrPrimaryWeaponModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels.WzBrLoadoutModels
{
    public class Weapon
    {
        public string name { get; set; }
        public string label { get; set; }
        public decimal variant { get; set; }
        public List<Attachment> attachments { get; set; }
    }
}
