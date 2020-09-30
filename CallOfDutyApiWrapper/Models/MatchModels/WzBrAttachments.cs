using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels.WzBrLoadoutModels.WzBrPrimaryWeaponModels
{
    public class WzBrAttachment
    {
        public string Name { get; set; }
        public string Label { get; set; }
        public string Category { get; set; }

        public WzBrAttachment(JToken jToken)
        {
            Name = jToken["name"].ToString();
            Label = jToken["label"].ToString();
            Category = jToken["category"].ToString();
        }
    }
}
