namespace CheapFlightsScanner.Core.DTO
{
    public class SegmentDto
    {
        public DepartureDto departure { get; set; }
        public ArrivalDto arrival { get; set; }
        public string carrierCode { get; set; }
        public string number { get; set; }
        public AircraftDto aircraft { get; set; }
        public OperatingDto operating { get; set; }
        public string duration { get; set; }
        public string id { get; set; }
        public int numberOfStops { get; set; }
        public bool blacklistedInEU { get; set; }
    }
}