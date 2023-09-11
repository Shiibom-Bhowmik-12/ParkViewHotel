using Microsoft.AspNetCore.Mvc;
using Parkview.Models;
using Parkview.ViewModels;
using System.Runtime.InteropServices;

namespace Parkview.Controllers
{
    public class HotelController : Controller
    {
        private readonly IHotelRepo _hotelRepo;
        private readonly IRoomRepo _roomRepo;

        public HotelController(IHotelRepo hotelRepo, IRoomRepo roomRepo)
        {
            _hotelRepo = hotelRepo;
            _roomRepo = roomRepo;
        }

        public IActionResult Index()
        {
            var allHotels = _hotelRepo.GetAllHotels;
            return View(allHotels);
        }

        public IActionResult HotelDetail(int hId)
        {
            var hotelDetail = _hotelRepo.GetHotelById(hId);
            var listOfRooms = _roomRepo.GetRooms.Where(room => room.HotelId == hId);
            HotelViewModel hotelviewmodel = new(hotelDetail, listOfRooms);
            return View(hotelviewmodel);
        }

        public IActionResult SearchHotelByName(string searchQuery)
        {
            var allHotels = _hotelRepo.SearchHotels(searchQuery);
            return View(allHotels);
        }
    }
}
