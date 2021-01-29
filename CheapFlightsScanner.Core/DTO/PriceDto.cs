using System.Collections.Generic;

namespace CheapFlightsScanner.Core.DTO
{
    public class PriceDto
    {
        public string currency { get; set; } 
        public string total { get; set; } 
        public string @base { get; set; } 
        public List<FeeDto> fees { get; set; } 
        public string grandTotal { get; set; }
    }
}