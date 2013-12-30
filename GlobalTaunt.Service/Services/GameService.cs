using System.Collections.Generic;
using RestSharp;
using GlobalTaunt.Model;
using GlobalTaunt.Interface;

namespace GlobalTaunt.Service
{
    public class GameService : BaseService, IGameService
    {
        #region Methods

        /// <summary>
        /// Get recent games by summoner ID
        /// </summary>
        public IList<Game> GetRecent(SummonerRegion region, long id)
        {
            var request = new RestRequest("/api/lol/{region}/v1.2/game/by-summoner/{id}/recent", Method.GET);

            request.AddUrlSegment("id", id.ToString());
            request.AddUrlSegment("region", region.ToString().ToLower());

            return Execute<RecentGames>(request).Games;
        }

        #endregion
    }
}
