using Microsoft.AspNetCore.Mvc;
using Parkview.Models;
using Parkview.ViewModels;

namespace Parkview.Controllers
{
    public class HotelChainController : Controller
    {
        private readonly IHotelChainRepo _hotelChainRepo;
        private readonly IHotelRepo _hotelRepo;
        private readonly IDestinationRepo _destinationRepo;



        public HotelChainController(IHotelChainRepo hotelChainRepo, IHotelRepo hotelRepo, IDestinationRepo destinationRepo)
        {
            _hotelChainRepo = hotelChainRepo;
            _hotelRepo = hotelRepo;
            _destinationRepo = destinationRepo;



        }
        public IActionResult Index()
        {
            var allHotelChains = _hotelChainRepo.AllHotelChain;
            return View(allHotelChains);
        }



        public IActionResult HotelChainDetail(int id)
        {
            var hotelChainDetail = _hotelChainRepo.GetHotelChainById(id);
            var listOfHotels = _hotelRepo.ListOfHotelsByHotelChain(id);
            var listOfDest = _destinationRepo.ListOfDestinationsByHotelChain(id);



            HotelChainListViewModel hotelchainmodel = new(hotelChainDetail, listOfHotels, listOfDest);



            return View(hotelchainmodel);
        }


        public IActionResult SearchHotelChain(string searchQuery)
        {
            var hotelchains = _hotelChainRepo.SearchHotelChainByName(searchQuery);
            return View(hotelchains);
        }
    }
}
