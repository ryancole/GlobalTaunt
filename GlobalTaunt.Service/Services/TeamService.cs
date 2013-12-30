using System.Collections.Generic;
using RestSharp;
using GlobalTaunt.Model;
using GlobalTaunt.Interface;

namespace GlobalTaunt.Service
{
    public class TeamService : BaseService, ITeamService
    {
        #region Methods

        /// <summary>
        /// Retrieves teams for given summoner ID 
        /// </summary>
        public IList<Team> GetBySummoner(SummonerRegion region, int id)
        {
            var request = new RestRequest("/api/lol/{region}/v2.2/team/by-summoner/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());
            request.AddUrlSegment("region", region.ToString().ToLower());

            return Execute<List<Team>>(request);
        }

        #endregion
    }
}
