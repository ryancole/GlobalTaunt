using System.Collections.Generic;
using GlobalTaunt.Model;

namespace GlobalTaunt.Interface
{
    public interface ITeamService : IBaseService
    {
        #region Methods

        /// <summary>
        /// Retrieves teams for given summoner ID 
        /// </summary>
        IList<Team> GetBySummoner(Region region, int id);

        #endregion
    }
}
