namespace Parkview.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        //Foreign key to HotelChain
        public int HotelChainId { get; set; }

        //this is the navigation property for rooms belonging to this hotel
        public ICollection<Room>? Rooms { get; set; }

        //this is the navigation property for reservations belonging to this hotel
        public ICollection<Reservation>? Reservations { get; set; }
    }
}