using CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels.WzBrLoadoutModels.WzBrPrimaryWeaponModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels.WzBrLoadoutModels
{
    public class SecondaryWeapon
    {
        public string name { get; set; }
        public string label { get; set; }
        public int variant { get; set; }
        public List<Attachment> attachments { get; set; }
    }
}
