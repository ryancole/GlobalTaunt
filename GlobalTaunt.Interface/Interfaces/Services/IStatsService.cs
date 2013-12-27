using System.Collections.Generic;
using GlobalTaunt.Model;

namespace GlobalTaunt.Interface
{
    public interface IStatsService : IBaseService
    {
        #region Methods

        /// <summary>
        /// Get player stats summaries by summoner ID. One summary is returned per queue type
        /// </summary>
        IList<PlayerStatsSummary> GetSummaryBySummoner(Region region, StatsSeason season, long id);

        #endregion
    }
}
