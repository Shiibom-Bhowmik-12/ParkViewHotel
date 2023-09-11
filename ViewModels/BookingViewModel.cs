using Parkview.Models;

namespace Parkview.ViewModels
{
    public class BookingViewModel
    {
        public Booking Booking { get; set; }
        public Room Room { get; set; }
        public BookingViewModel(Booking booking, Room room)
        {
            Booking = booking;
            Room = room;
        }
    }
}
