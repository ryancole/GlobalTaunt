namespace GlobalTaunt.Model
{
    public class Summoner
    {
        #region Properties

        public long Id { get; set; }

        public long SummonerLevel { get; set; }

        public long RevisionDate { get; set; }

        public string Name { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("{0} ({1}), Level {2}", Name, Id, SummonerLevel);
        }

        #endregion
    }

    public enum Region
    {
        NA,
        EUW,
        EUNE
    }
}
