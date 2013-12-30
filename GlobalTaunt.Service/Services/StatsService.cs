using System.Collections.Generic;
using RestSharp;
using GlobalTaunt.Model;
using GlobalTaunt.Interface;

namespace GlobalTaunt.Service
{
    public class StatsService : BaseService, IStatsService
    {
        #region Methods

        /// <summary>
        /// Get player stats summaries by summoner ID. One summary is returned per queue type
        /// </summary>
        public IList<PlayerStatsSummary> GetSummaryBySummoner(SummonerRegion region, StatsSeason season, long id)
        {
            var request = new RestRequest("/api/lol/{region}/v1.2/stats/by-summoner/{id}/summary", Method.GET);

            request.AddUrlSegment("id", id.ToString());
            request.AddUrlSegment("region", region.ToString().ToLower());
            request.AddParameter("season", season.ToString());

            return Execute<PlayerStatsSummaryList>(request).PlayerStatSummaries;
        }

        /// <summary>
        /// ked Get ranked stats by summoner ID. Includes statistics for Twisted Treeline and Summoner's Rift
        /// </summary>
        public IList<PlayerRankedChampionStats> GetRankedBySummoner(SummonerRegion region, StatsSeason season, long id)
        {
            var request = new RestRequest("/api/lol/{region}/v1.2/stats/by-summoner/{id}/ranked", Method.GET);

            request.AddUrlSegment("id", id.ToString());
            request.AddUrlSegment("region", region.ToString().ToLower());
            request.AddParameter("season", season.ToString());

            return Execute<PlayerRankedStats>(request).Champions;
        }

        #endregion
    }
}
