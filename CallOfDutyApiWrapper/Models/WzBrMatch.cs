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
    }
}
