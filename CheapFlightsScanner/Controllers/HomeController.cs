using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CheapFlightsScanner.Models;
using CheapFlightsScanner.Core.Forms;
using CheapFlightsScanner.Core.DTO;
using CheapFlightsScanner.Infrastructure.Interface;

namespace CheapFlightsScanner.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFlightOffersCacheService _flightOffersCacheService;

        public HomeController(ILogger<HomeController> logger, IFlightOffersCacheService flightOffersCacheService)
        {
            _logger = logger;
            _flightOffersCacheService = flightOffersCacheService;
        }

        [HttpGet]
        public IActionResult Index(FlightOffersDTO flightOffers)
        {
            return View(flightOffers);
        }

        [HttpPost]
        public async Task<IActionResult> Index(FlightOffersForm flightOffersForm)
        {
            var getFlightOffers = await GetFlightOffers(flightOffersForm);

            var flightOffers = new FlightOffersDTO();
            flightOffers.FlightOffersForm = flightOffersForm;
            flightOffers.GetFlightOffersResponseDto = getFlightOffers.data;

            return View(flightOffers);
        }

        private async Task<GetFlightOffersResponseDTO> GetFlightOffers(FlightOffersForm flightOffersForm)
        {
            return await _flightOffersCacheService.GetFlightOffers(flightOffersForm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
