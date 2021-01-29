using CheapFlightsScanner.Core.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheapFlightsScanner.Core.DTO
{
    public class FlightOffersDTO
    {
        public FlightOffersDTO()
        {
            FlightOffersForm = new FlightOffersForm();
            GetFlightOffersResponseDto = new List<GetFlightOffersResponseDataDto>();
        }

        public FlightOffersForm FlightOffersForm { get; set; }
        public List<GetFlightOffersResponseDataDto> GetFlightOffersResponseDto { get; set; }
    }
}
