using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDutyApiWrapper.Models
{
    public class Match
    {
        public int utcStartSeconds { get; set; }
        public int utcEndSeconds { get; set; }
        public string map { get; set; }
        public string mode { get; set; }
        public ulong matchID { get; set; }
        public int duration { get; set; }
        public string playlistName { get; set; }
        public int version { get; set; }
        public string gameType { get; set; }
        public int playerCount { get; set; }
        // public PlayerStats playerStats { get; set; }
        // public Player player { get; set; }
        public int teamCount { get; set; }
        public string rankedTeams { get; set; }
        public bool draw { get; set; }
        public bool privateMatch { get; set; }


        // public Match(JToken jToken)
        // {
        //     Int32.TryParse(jToken["utcStartSeconds"].ToString(), out int startTime);
        //     // UtcStartSeconds = startTime;

        //     Int32.TryParse(jToken["utcEndSeconds"].ToString(), out int endTime);
        //     UtcEndSeconds = endTime;

        //     Map = jToken["map"].ToString();
        //     Mode = jToken["mode"].ToString();

        //     ulong.TryParse(jToken["matchID"].ToString(), out ulong matchID);
        //     MatchID = matchID;

        //     Int32.TryParse(jToken["duration"].ToString(), out int duration);
        //     Duration = duration;

        //     PlaylistName = jToken["playlistName"].ToString();

        //     Int32.TryParse(jToken["version"].ToString(), out int version);
        //     Version = version;

        //     GameType = jToken["gameType"].ToString();

        //     Int32.TryParse(jToken["playerCount"].ToString(), out int playerCount);
        //     PlayerCount = playerCount;

        //     var playerStats = jToken["playerStats"];
        //     PlayerStats = new WzBrPlayerStats(playerStats);

        //     var player = jToken["player"];
        //     Player = new WzBrPlayer(player);
        // }
    }
}