using CallOfDutyApiWrapper.Models.MatchModels.WzBrPlayerModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDutyApiWrapper.Models
{
    public class WzBrPlayer
    {
        public string Team { get; set; }
        public int Rank { get; set; }
        public string[] Awards { get; set; }
        public string Username { get; set; }
        public ulong Uno { get; set; }
        public string Clantang { get; set; }
        public WzBrMissionStats BrMissionStats { get; set; }
        public WzBrLoadout Loadout { get; set; }

        public WzBrPlayer(JToken jToken)
        {
            Team = jToken["team"].ToString();

            Int32.TryParse(jToken["rank"].ToString(), out int rank);
            Rank = rank;

            Awards = jToken["awards"].ToObject<string[]>();

            Username = jToken["username"].ToString();

            ulong.TryParse(jToken["uno"].ToString(), out ulong uno);
            Uno = uno;

            Clantang = jToken["clantang"].ToString();

            var brMissionStats = jToken["brMissionStats"];
            BrMissionStats = new WzBrMissionStats(brMissionStats);

            var loadout = jToken["loadout"];
            Loadout = new WzBrLoadout(loadout);


        }
    }
}
