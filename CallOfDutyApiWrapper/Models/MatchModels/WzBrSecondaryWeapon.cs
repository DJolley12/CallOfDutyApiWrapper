using CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels.WzBrLoadoutModels.WzBrPrimaryWeaponModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels.WzBrLoadoutModels
{
    public class WzBrSecondaryWeapon
    {
        public string Name { get; set; }
        public string Label { get; set; }
        public int Variant { get; set; }
        public List<WzBrAttachment> Attachments { get; set; }
    }
}
