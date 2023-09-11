namespace Parkview.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        //Foreign key to User 
        public int UserId { get; set; }

        //Foreign key to Room 
        public int RoomId { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public decimal ReservationPaid { get; set; }

        public User? User { get; set; }//this is the navigation property

        public Room? Room { get; set; }//this is the navigation property

        public Hotel? Hotel { get; set; } // this is the navigation property
    }
}