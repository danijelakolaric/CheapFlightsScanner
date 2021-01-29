using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CheapFlightsScanner.Core.Forms
{
    public class FlightOffersForm
    {       
        [Required]
        public string OriginLocationCode { get; set; }
        [Required]
        public string DestinationLocationCode { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{YYYY-MM-DD}")]
        [DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }
        [Required]
        public int Adults { get; set; }

        public string GetUniqueKey()
        {
            var key = string.Format("originLocationCode={0}&destinationLocationCode={1}&departureDate={2}&adults={3}",
                OriginLocationCode, DestinationLocationCode, DepartureDate.ToString("yyyy-MM-dd"), Adults);

            return key;
        }
    }
}
