using System.Collections.Generic;
using RestSharp;
using GlobalTaunt.Model;
using GlobalTaunt.Interface;

namespace GlobalTaunt.Service
{
    public class LeagueService : BaseService, ILeagueService
    {
        #region Methods

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams 
        /// </summary>
        public IDictionary<string, League> Get(Region region, long id)
        {
            var request = new RestRequest("/api/lol/{region}/v2.2/league/by-summoner/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());
            request.AddUrlSegment("region", region.ToString().ToLower());

            return Execute<Dictionary<string, League>>(request);
        }

        #endregion
    }
}
