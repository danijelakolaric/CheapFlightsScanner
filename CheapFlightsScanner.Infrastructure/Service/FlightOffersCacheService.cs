using CheapFlightsScanner.Core.DTO;
using CheapFlightsScanner.Core.Forms;
using CheapFlightsScanner.Infrastructure.Interface;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CheapFlightsScanner.Infrastructure.Service
{
    public class FlightOffersCacheService : IFlightOffersCacheService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IFlightOffersService _flightOffersService;

        public FlightOffersCacheService(IMemoryCache memoryCache, IFlightOffersService flightOffersService)
        {
            _memoryCache = memoryCache;
            _flightOffersService = flightOffersService;
        }

        public async Task<GetFlightOffersResponseDTO> GetFlightOffers(FlightOffersForm flightOffersForm)
        {
            var cacheKey = flightOffersForm.GetUniqueKey();
            GetFlightOffersResponseDTO response;

            if (!_memoryCache.TryGetValue<GetFlightOffersResponseDTO>(cacheKey, out response))
            {
                response = await _flightOffersService.GetAsync(flightOffersForm);
                _memoryCache.Set(cacheKey, response);
            }
            else
            {
                response = _memoryCache.Get(cacheKey) as GetFlightOffersResponseDTO;
            }

            return response;
        }
    }
}
