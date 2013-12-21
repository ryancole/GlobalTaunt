using GlobalTaunt.Model;

namespace GlobalTaunt.Interface
{
    public interface ISummonerService : IBaseService
    {
        #region Methods

        /// <summary>
        /// Get Summoner by id
        /// </summary>
        Summoner Get(Region region, long id);

        /// <summary>
        /// Get Summoner by Name
        /// </summary>
        Summoner Get(Region region, string name);

        #endregion
    }
}
