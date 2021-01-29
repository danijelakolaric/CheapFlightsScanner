using System;

namespace CheapFlightsScanner.Core.DTO
{
    public class DepartureDto
    {
        public string iataCode { get; set; }
        public string terminal { get; set; }
        public DateTime at { get; set; }
    }
}