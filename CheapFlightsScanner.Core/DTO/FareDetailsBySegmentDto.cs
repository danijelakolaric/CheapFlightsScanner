namespace CheapFlightsScanner.Core.DTO
{
    public class FareDetailsBySegmentDto
    {
        public string segmentId { get; set; }
        public string cabin { get; set; }
        public string fareBasis { get; set; }
        public string @class { get; set; }
        public IncludedCheckedBagsDto includedCheckedBags { get; set; }
    }
}