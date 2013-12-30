using System.Collections.Generic;
using GlobalTaunt.Model;

namespace GlobalTaunt.Interface
{
    public interface ILeagueService : IBaseService
    {
        #region Methods

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams 
        /// </summary>
        IDictionary<string, League> Get(SummonerRegion region, long id);

        #endregion
    }
}
