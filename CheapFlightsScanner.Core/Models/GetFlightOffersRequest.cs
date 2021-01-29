using CheapFlightsScanner.Core.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace CheapFlightsScanner.Core.Models
{
    public class GetFlightOffersRequest
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string OriginLocationCode { get; set; }
        [Required]
        public string DestinationLocationCode { get; set; }
        [Required]
        public string DepartureDate { get; set; }
        public string ReturnDate { get; set; }
        [Required]
        public int Adults { get; set; }
        public int Children { get; set; }
        public int Infants { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TravelClass TravelClass { get; set; }
        public string IncludedAirlineCodes { get; set; }
        public string ExcludedAirlineCodes { get; set; }
        public bool NonStop { get; set; }
        public string CurrencyCode { get; set; }
        public int MaxPrice { get; set; }
        public int Max { get; set; }
    }
}
