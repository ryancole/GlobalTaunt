using System.Collections.Generic;
using GlobalTaunt.Model;

namespace GlobalTaunt.Interface
{
    public interface IGameService : IBaseService
    {
        #region Methods

        /// <summary>
        /// Get recent games by summoner ID
        /// </summary>
        IList<Game> GetRecent(SummonerRegion region, long id);

        #endregion
    }
}
