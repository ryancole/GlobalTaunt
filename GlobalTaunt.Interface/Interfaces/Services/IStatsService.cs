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
        IList<PlayerStatsSummary> GetSummaryBySummoner(SummonerRegion region, StatsSeason season, long id);

        /// <summary>
        /// ked Get ranked stats by summoner ID. Includes statistics for Twisted Treeline and Summoner's Rift
        /// </summary>
        IList<PlayerRankedChampionStats> GetRankedBySummoner(SummonerRegion region, StatsSeason season, long id);

        #endregion
    }
}
