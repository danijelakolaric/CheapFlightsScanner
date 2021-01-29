using System.Collections.Generic;

namespace CheapFlightsScanner.Core.DTO
{
    public class ItineraryDto
    {
        public string duration { get; set; }
        public List<SegmentDto> segments { get; set; }
    }
}