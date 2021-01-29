using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CheapFlightsScanner.Core.DTO
{
    public class GetFlightOfferRequestDto
    {
        public int id { get; set; }
        public string originLocationCode { get; set; }
        public string destinationLocationCode { get; set; }
        public string departureDate { get; set; }
        public string returnDate { get; set; }
        public int adults { get; set; }
        public int children { get; set; }
        public int infants { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TravelClass travelClass { get; set; }
        public string includedAirlineCodes { get; set; }
        public string excludedAirlineCodes { get; set; }
        public bool nonStop { get; set; }
        public string currencyCode { get; set; }
        public int maxPrice { get; set; }
        public int max { get; set; }
    }
}
