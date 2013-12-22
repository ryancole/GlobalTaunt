using System.Collections.Generic;

namespace GlobalTaunt.Model
{
    public class League
    {
        #region Properties

        public string Tier { get; set; }

        public string Name { get; set; }

        public string Queue { get; set; }

        public Dictionary<string, LeagueItem> Entries { get; set; }

        #endregion
    }

    public class LeagueItem
    {
        #region Properties

        public int Wins { get; set; }

        public int LeaguePoints { get; set; }

        public bool IsVeteran { get; set; }

        public bool IsInactive { get; set; }

        public bool IsHotStreak { get; set; }

        public bool IsFreshBlood { get; set; }

        public long LastPlayed { get; set; }

        public string LeagueName { get; set; }

        public string PlayerOrTeamId { get; set; }

        public string PlayerOrTeamName { get; set; }

        public string QueueType { get; set; }

        public string Rank { get; set; }

        public string Tier { get; set; }

        public LeagueMiniSeries MiniSeries { get; set; }

        #endregion
    }

    public class LeagueMiniSeries
    {
        #region Properties

        public int Wins { get; set; }

        public int Loses { get; set; }

        public int Target { get; set; }

        public long TimeLeftToPlayMillis { get; set; }

        public List<char> Progress { get; set; }

        #endregion
    }
}
