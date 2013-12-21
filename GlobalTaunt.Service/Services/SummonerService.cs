﻿using RestSharp;
using GlobalTaunt.Model;
using GlobalTaunt.Interface;

namespace GlobalTaunt.Service
{
    public class SummonerService : BaseService, ISummonerService
    {
        #region Methods

        /// <summary>
        /// Get Summoner by id
        /// </summary>
        public Summoner Get(Region region, long id)
        {
            var request = new RestRequest("/api/lol/{region}/v1.2/summoner/{id}", Method.GET);

            request.AddUrlSegment("id", id.ToString());
            request.AddUrlSegment("region", region.ToString().ToLower());

            return Execute<Summoner>(request);
        }

        /// <summary>
        /// Get Summoner by Name
        /// </summary>
        public Summoner Get(Region region, string name)
        {
            var request = new RestRequest("/api/lol/{region}/v1.2/summoner/by-name/{name}", Method.GET);

            request.AddUrlSegment("name", name);
            request.AddUrlSegment("region", region.ToString().ToLower());

            return Execute<Summoner>(request);
        }

        #endregion
    }
}
