using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CheapFlightsScanner.Core.DTO
{
    public class GetFlightOffersResponseDataDto
    {
        public string type { get; set; }
        public string id { get; set; }
        public string source { get; set; }
        public bool instantTicketingRequired { get; set; }
        public bool nonHomogeneous { get; set; }
        public bool oneWay { get; set; }
        public string lastTicketingDate { get; set; }
        public int numberOfBookableSeats { get; set; }
        public List<ItineraryDto> itineraries { get; set; }
        public PriceDto price { get; set; }
        public PricingOptionsDto pricingOptions { get; set; }
        public List<string> validatingAirlineCodes { get; set; }
        public List<TravelerPricingDto> travelerPricings { get; set; }
    }
}
