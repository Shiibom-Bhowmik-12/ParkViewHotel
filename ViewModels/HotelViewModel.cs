using Parkview.Models;

namespace Parkview.ViewModels
{
    public class HotelViewModel
    {
        public Hotel Hotel;

        public IEnumerable<Room> Rooms;

        public HotelViewModel(Hotel hotel, IEnumerable<Room> rooms)
        {
            Hotel = hotel;
            Rooms = rooms;
        }
    }
}
