using GlobalTaunt.Model;

namespace GlobalTaunt.Interface
{
    public interface ISummonerService : IBaseService
    {
        #region Methods

        /// <summary>
        /// Get Summoner by id
        /// </summary>
        Summoner Get(SummonerRegion region, long id);

        /// <summary>
        /// Get Summoner by Name
        /// </summary>
        Summoner Get(SummonerRegion region, string name);

        #endregion
    }
}
