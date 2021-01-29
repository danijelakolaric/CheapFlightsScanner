using CheapFlightsScanner.Core.DTO;
using CheapFlightsScanner.Core.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CheapFlightsScanner.Infrastructure.Interface
{
    public interface IFlightOffersCacheService
    {
        Task<GetFlightOffersResponseDTO> GetFlightOffers(FlightOffersForm flightOffersForm);
    }
}
