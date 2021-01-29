using CheapFlightsScanner.Core.DTO;
using CheapFlightsScanner.Core.Forms;
using CheapFlightsScanner.Infrastructure.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CheapFlightsScanner.Infrastructure.Service
{
    public class FlightOffersService : IFlightOffersService
    {
        private const string uri = "v2/shopping/flight-offers";
        private readonly HttpClient _httpClient;
        private readonly ICodeGrantOAuthService _codeGrantOAuth;

        public FlightOffersService(HttpClient httpClient, ICodeGrantOAuthService codeGrantOAuth)
        {
            _httpClient = httpClient;
            _codeGrantOAuth = codeGrantOAuth;
        }

        public async Task<GetFlightOffersResponseDTO> GetAsync(FlightOffersForm flightOffersForm)
        {
            var _token = _codeGrantOAuth.GetAccessToken();

            _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _token);

            var uriWithParameters = GetUri(flightOffersForm);

            var httpResponse = await _httpClient.GetAsync(uriWithParameters);

            if (httpResponse.IsSuccessStatusCode)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<GetFlightOffersResponseDTO>(content);
            }

            return new GetFlightOffersResponseDTO();
        }

        private string GetUri(FlightOffersForm flightOffersForm)
        {
            var uriBuilder = new UriBuilder(_httpClient.BaseAddress.AbsoluteUri + uri);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["originLocationCode"] = flightOffersForm.OriginLocationCode;
            query["destinationLocationCode"] = flightOffersForm.DestinationLocationCode;
            query["departureDate"] = flightOffersForm.DepartureDate.ToString("yyyy-MM-dd");
            query["adults"] = flightOffersForm.Adults.ToString();
            uriBuilder.Query = query.ToString();
            return uriBuilder.ToString().Replace(_httpClient.BaseAddress.AbsoluteUri, "");
        }
    }
}
