using System.Collections.Generic;
using RestSharp;
using GlobalTaunt.Model;
using GlobalTaunt.Interface;

namespace GlobalTaunt.Service
{
    public class ChampionService : BaseService, IChampionService
    {
        #region Methods

        /// <summary>
        /// Retrieve all champions
        /// </summary>
        public IList<Champion> Get(Region region)
        {
            var request = new RestRequest("/api/lol/{region}/v1.1/champion", Method.GET);

            request.AddUrlSegment("region", region.ToString().ToLower());

            return Execute<AllChampions>(request).Champions;
        }

        #endregion
    }
}
