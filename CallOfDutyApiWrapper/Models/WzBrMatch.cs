using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDutyApiWrapper.Models
{
    public class WzBrMatch
    {
        public int UtcStartSeconds { get; set; }
        public int UtcEndSeconds { get; set; }
        public string Map { get; set; }
        public string Mode { get; set; }
        public ulong MatchId { get; set; }
        public int Duration { get; set; }
        public string PlaylistName { get; set; }
        public int Version { get; set; }
        public string GameType { get; set; }
        public int PlayerCount { get; set; }
        public WzBrPlayerStats PlayerStats { get; set; }
        public WzBrPlayer Player { get; set; }
        public int TeamCount { get; set; }
        public string RankedTeams { get; set; }
        public bool Draw { get; set; }
        public bool PrivateMatch { get; set; }

        public WzBrMatch(JObject jObject)
        {
            Int32.TryParse(jObject["utcStartSeconds"].ToString(), out int startTime);
            UtcStartSeconds = startTime;

            Int32.TryParse(jObject["utcEndSeconds"].ToString(), out int endTime);
            UtcEndSeconds = endTime;

            Map = jObject["map"].ToString();
            Mode = jObject["mode"].ToString();

            ulong.TryParse(jObject["matchId"].ToString(), out ulong matchId);
            MatchId = matchId;

            Int32.TryParse(jObject["duration"].ToString(), out int duration);
            Duration = duration;

            PlaylistName = jObject["playlistName"].ToString();

            Int32.TryParse(jObject["version"].ToString(), out int version);
            Version = version;

        }
    }
}