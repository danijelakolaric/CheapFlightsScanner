using CheapFlightsScanner.Core.DTO;
using CheapFlightsScanner.Infrastructure.Interface;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CheapFlightsScanner.Infrastructure.Service
{
    public class CodeGrantOAuthService : ICodeGrantOAuthService
    {
        private string _baseUrl = "https://test.api.amadeus.com/v1/security/oauth2/token";
        private string _clientId = "suoU8GN0ZjLUn7X1hLDornimeTDlYAD3";
        private string _clientSecret = "kA46qdODkYog9l5N";
        private static string _token;

        public string GetAccessToken()
        {
            if (_token == null)
            {
                RefreshAccessToken();
            }

            var url = _baseUrl + "/" + _token;

            var client = new RestClient(url);

            client.Timeout = -1;

            var request = new RestRequest(Method.GET);

            var response = client.Execute(request);

            return JsonConvert.DeserializeObject<TokenDto>(response.Content).access_token;
        }

        public string RefreshAccessToken()
        {
            var client = new RestClient(_baseUrl);

            client.Timeout = -1;

            var request = new RestRequest(Method.POST);

            request.AddParameter("client_id", _clientId);
            request.AddParameter("client_secret", _clientSecret);
            request.AddParameter("grant_type", "client_credentials");

            var response = client.Execute(request);
            _token = JsonConvert.DeserializeObject<TokenDto>(response.Content).access_token; 

            return _token;
        }
    }
}
