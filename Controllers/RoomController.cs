using Microsoft.AspNetCore.Mvc;
using Parkview.Models;

namespace Parkview.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomRepo _roomDbRepo;
        public RoomController(IRoomRepo roomDbRepo)
        {
            _roomDbRepo = roomDbRepo;
        }
        public IActionResult Index()
        {
            var rooms = _roomDbRepo.GetRooms;
            return View(rooms);
        }

        public IActionResult RoomDetail(int roomId)
        {
            var room = _roomDbRepo.GetRoomById(roomId);
            return View(room);
        }
    }
}
