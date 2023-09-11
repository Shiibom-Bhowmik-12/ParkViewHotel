using System.Runtime.InteropServices;

namespace Parkview.Models
{
    public class Room
    {
       public int RoomId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        //Foreign key to Hotel
        public int? HotelId { get; set; }

        public int NoOfRooms { get; set; }

        public string? RoomType { get; set; }

        public decimal? RoomPrice { get; set; }

        //this is the navigation property for reservations belonging to this room
        public ICollection<Reservation>? Reservations { get; set; }
    }
}