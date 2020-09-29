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
        public ulong MatchID { get; set; }
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

        public WzBrMatch(JToken jToken)
        {
            Int32.TryParse(jToken["utcStartSeconds"].ToString(), out int startTime);
            UtcStartSeconds = startTime;

            Int32.TryParse(jToken["utcEndSeconds"].ToString(), out int endTime);
            UtcEndSeconds = endTime;

            Map = jToken["map"].ToString();
            Mode = jToken["mode"].ToString();

            ulong.TryParse(jToken["matchID"].ToString(), out ulong matchID);
            MatchID = matchID;

            Int32.TryParse(jToken["duration"].ToString(), out int duration);
            Duration = duration;

            PlaylistName = jToken["playlistName"].ToString();

            Int32.TryParse(jToken["version"].ToString(), out int version);
            Version = version;

            GameType = jToken["gameType"].ToString();

            Int32.TryParse(jToken["playerCount"].ToString(), out int playerCount);
            PlayerCount = playerCount;


        }
    }
}