using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDutyApiWrapper.Models
{
    public class Match
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
        public Result Result { get; set; }
        public string WinningTeam { get; set; }
        public bool GameBattle { get; set; }
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }
        public bool PresentAtEnd { get; set; }
        public Player Player { get; set; }
        public PlayerStats PlayerStats { get; set; }
    }

    public enum Result
    {
        Lose, 
        Win
    }
}
