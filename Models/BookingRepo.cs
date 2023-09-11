namespace Parkview.Models
{
    public class BookingRepo : IBookingRepo
    {
        private readonly ParkviewDbContext _parkviewDbContext;
        private readonly IRoomRepo _roomRepo;

        public BookingRepo(ParkviewDbContext parkviewDbContext, IRoomRepo roomRepo)
        {
            _parkviewDbContext = parkviewDbContext;
            _roomRepo = roomRepo;
        }

        public IEnumerable<Booking> GetAllBookings
        {
            get
            {
                return _parkviewDbContext.Bookings;
            }
        }

        public Booking GetBooking(int id)
        {
            return _parkviewDbContext.Bookings.FirstOrDefault(book => book.BookingId == id);
        }

        public void SubmitBooking(Booking booking)
        {
            var room = _roomRepo.GetRoomById(booking.RoomId);
            room.NoOfRooms -= booking.NoOfRooms;
            _parkviewDbContext.Bookings.Add(booking);
            _parkviewDbContext.SaveChanges();
        }

        public void CancelBooking(int id)
        {
            var booking = _parkviewDbContext.Bookings.FirstOrDefault(book => book.BookingId == id);
            var room = _roomRepo.GetRoomById(booking.RoomId);
            room.NoOfRooms += booking.NoOfRooms;
            _parkviewDbContext.Bookings.Remove(booking);
            _parkviewDbContext.SaveChanges();
        }



        public IEnumerable<Booking> BookingListByUser(string userId)
        {
            return _parkviewDbContext.Bookings.Where(booking => booking.UserId == userId);
        }
    }
}
