using System.Collections.Generic;

namespace CheapFlightsScanner.Core.DTO
{
    public class TravelerPricingDto
    {
        public string travelerId { get; set; }
        public string fareOption { get; set; }
        public string travelerType { get; set; }
        public PriceDto price { get; set; }
        public List<FareDetailsBySegmentDto> fareDetailsBySegment { get; set; }
    }
}