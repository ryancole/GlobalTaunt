namespace GlobalTaunt.Model
{
    public class Summoner
    {
        #region Properties

        public long Id { get; set; }

        public long SummonerLevel { get; set; }

        public long RevisionDate { get; set; }

        public string Name { get; set; }

        public SummonerRegion Region { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("{0} @ {1} ({2}), Level {3}", Name, Region, Id, SummonerLevel);
        }

        #endregion
    }

    public enum SummonerRegion
    {
        NA,
        EUW,
        EUNE
    }
}
