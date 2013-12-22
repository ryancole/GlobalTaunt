using System.Collections.Generic;

namespace GlobalTaunt.Model
{
    public class Champion
    {
        #region Properties

        public int AttackRank { get; set; }

        public int DefenseRank { get; set; }

        public int DifficultyRank { get; set; }

        public int MagicRank { get; set; }

        public bool Active { get; set; }

        public bool BotEnabled { get; set; }

        public bool BotMmEnabled { get; set; }

        public bool FreeToPlay { get; set; }

        public bool RankedPlayEnabled { get; set; }

        public long Id { get; set; }

        public string Name { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return Name;
        }

        #endregion
    }

    public class AllChampions
    {
        #region Properties

        public List<Champion> Champions { get; set; }

        #endregion
    }
}
