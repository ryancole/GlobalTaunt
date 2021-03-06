﻿using System;
using RestSharp;
using GlobalTaunt.Model;
using GlobalTaunt.Interface;

namespace GlobalTaunt.Service
{
    public abstract class BaseService : IBaseService
    {
        #region Methods

        public T Execute<T>(IRestRequest request) where T : new()
        {
            var client = new RestClient("https://prod.api.pvp.net");

            // every request requires an access token
            request.AddParameter("api_key", ApiKey ?? "");

            // make the request and deserialze to model
            var response = client.Execute<T>(request);

            if (response.ErrorException != null || response.StatusCode != System.Net.HttpStatusCode.OK)
                throw new Exception(response.StatusDescription, response.ErrorException);

            return response.Data;
        }

        #endregion

        #region Properties

        public string ApiKey { get; set; }

        #endregion
    }
}
