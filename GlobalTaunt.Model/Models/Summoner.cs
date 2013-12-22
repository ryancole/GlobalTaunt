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
    }

    public enum Region
    {
        NA,
        EUW,
        EUNE
    }
}
