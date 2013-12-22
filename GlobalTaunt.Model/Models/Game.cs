using System.Collections.Generic;

namespace GlobalTaunt.Model
{
    public class Game
    {
        #region Properties

        public int Level { get; set; }

        public int MapId { get; set; }

        public int Spell1 { get; set; }

        public int Spell2 { get; set; }

        public int TeamId { get; set; }

        public int ChampionId { get; set; }

        public long GameId { get; set; }

        public long CreateDate { get; set; }

        public bool Invalid { get; set; }

        public string SubType { get; set; }

        public string GameMode { get; set; }

        public string GameType { get; set; }

        #endregion
    }

    public class RecentGames
    {
        #region Properties

        public long SummonerId { get; set; }

        public List<Game> Games { get; set; }

        #endregion
    }
}
