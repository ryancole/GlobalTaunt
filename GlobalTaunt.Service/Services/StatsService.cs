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
        public IList<PlayerStatsSummary> GetSummaryBySummoner(Region region, StatsSeason season, long id)
        {
            var request = new RestRequest("/api/lol/{region}/v1.2/stats/by-summoner/{id}/summary", Method.GET);

            request.AddUrlSegment("id", id.ToString());
            request.AddUrlSegment("region", region.ToString().ToLower());
            request.AddParameter("season", season.ToString());

            return Execute<PlayerStatsSummaryList>(request).PlayerStatSummaries;
        }

        #endregion
    }
}
