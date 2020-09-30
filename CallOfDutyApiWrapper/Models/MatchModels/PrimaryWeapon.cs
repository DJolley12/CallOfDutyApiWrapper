using CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels.WzBrLoadoutModels.WzBrPrimaryWeaponModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels.WzBrLoadoutModels
{
    public class PrimaryWeapon
    {
        public string Name { get; set; }
        public string Label { get; set; }
        public int Variant { get; set; }
        public List<Attachment> Attachments { get; set; }

        public PrimaryWeapon(JToken jToken)
        {
            Name = jToken["name"].ToString();
            Label = jToken["label"].ToString();

            Int32.TryParse(jToken["variant"].ToString(), out int variant);
            Variant = variant;

            var attachments = jToken["attachments"];
            Attachments = new List<Attachment>();
            for (int i = 0; i < attachments.Count(); i++)
            {
                var attachment = new Attachment(attachments[i]);
                Attachments.Add(attachment);
            }





        }
    }
}
