using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDutyApiWrapper.Models
{
    public class Match
    {
        public decimal utcStartSeconds { get; set; }
        public decimal utcEndSeconds { get; set; }
        public string map { get; set; }
        public string mode { get; set; }
        public ulong matchID { get; set; }
        public decimal duration { get; set; }
        public string playlistName { get; set; }
        public decimal version { get; set; }
        public string gameType { get; set; }
        public decimal playerCount { get; set; }
        public PlayerStats playerStats { get; set; }
        public Player player { get; set; }
        public decimal teamCount { get; set; }
        public string rankedTeams { get; set; }
        public bool draw { get; set; }
        public bool privateMatch { get; set; }


        // public Match(JToken jToken)
        // {
        //     decimal32.TryParse(jToken["utcStartSeconds"].ToString(), out decimal startTime);
        //     // UtcStartSeconds = startTime;

        //     decimal32.TryParse(jToken["utcEndSeconds"].ToString(), out decimal endTime);
        //     UtcEndSeconds = endTime;

        //     Map = jToken["map"].ToString();
        //     Mode = jToken["mode"].ToString();

        //     ulong.TryParse(jToken["matchID"].ToString(), out ulong matchID);
        //     MatchID = matchID;

        //     decimal32.TryParse(jToken["duration"].ToString(), out decimal duration);
        //     Duration = duration;

        //     PlaylistName = jToken["playlistName"].ToString();

        //     decimal32.TryParse(jToken["version"].ToString(), out decimal version);
        //     Version = version;

        //     GameType = jToken["gameType"].ToString();

        //     decimal32.TryParse(jToken["playerCount"].ToString(), out decimal playerCount);
        //     PlayerCount = playerCount;

        //     var playerStats = jToken["playerStats"];
        //     PlayerStats = new WzBrPlayerStats(playerStats);

        //     var player = jToken["player"];
        //     Player = new WzBrPlayer(player);
        // }
    }
}