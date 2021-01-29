using CheapFlightsScanner.Core.DTO;
using CheapFlightsScanner.Core.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CheapFlightsScanner.Infrastructure.Interface
{
    public interface IFlightOffersService
    {
        Task<GetFlightOffersResponseDTO> GetAsync(FlightOffersForm flightOffersForm); 
    }
}
