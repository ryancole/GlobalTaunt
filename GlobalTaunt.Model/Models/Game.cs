using System.Collections.Generic;

namespace GlobalTaunt.Model
{
    public class Game
    {
        #region Properties

        public int Level { get; set; }

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

        public GameMap MapId { get; set; }

        public List<GamePlayer> FellowPlayers { get; set; }

        public List<GameRawStats> Statistics { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("Game {0}, on {1}", GameId, MapId);
        }

        #endregion
    }

    public class GamePlayer
    {
        #region Properties

        public int TeamId { get; set; }

        public int ChampionId { get; set; }

        public long SummonerId { get; set; }

        #endregion
    }

    public class GameRawStats
    {
        #region Properties

        public int Id { get; set; }

        public int Value { get; set; }

        public string Name { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("{0} => {1}", Name, Value);
        }

        #endregion
    }

    public class RecentGames
    {
        #region Properties

        public long SummonerId { get; set; }

        public List<Game> Games { get; set; }

        #endregion
    }

    public enum GameMap
    {
        SummonersRiftSummer = 1,
        SummonersRiftAutumn = 2,
        ProvingGrounds = 3,
        TwistedTreelineOriginal = 4,
        CrystalScar = 8,
        TwistedTreeline = 10,
        HowlingAbyss = 12
    }
}
