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
        IList<Game> GetRecent(Region region, long id);

        #endregion
    }
}
