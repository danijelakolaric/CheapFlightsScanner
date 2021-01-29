using System.Collections.Generic;

namespace CheapFlightsScanner.Core.DTO
{
    public class PricingOptionsDto
    {
        public List<string> fareType { get; set; }
        public bool includedCheckedBagsOnly { get; set; }
    }
}