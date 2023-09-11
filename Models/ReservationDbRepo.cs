namespace Parkview.Models
{
    public class ReservationDbRepo : IReservationRepo
    {

        private readonly ParkviewDbContext _parkviewDbContext;

        public ReservationDbRepo(ParkviewDbContext parkviewDbContext)
        {
            _parkviewDbContext = parkviewDbContext;
        }
        public bool BookReservation(Reservation reservation)
        {
            if (reservation.CheckInDate > DateTime.Now)
            {
                _parkviewDbContext.Reservations.Add(reservation);
                _parkviewDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        Reservation IReservationRepo.GetReservation(int reservationId)
        {
            throw new NotImplementedException();
        }
    }
}
