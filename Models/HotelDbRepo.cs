namespace Parkview.Models
{
    public class HotelDbRepo : IHotelRepo
    {
        private readonly ParkviewDbContext _parkviewDbContext;

        public HotelDbRepo(ParkviewDbContext parkviewDbContext)
        {
            _parkviewDbContext = parkviewDbContext;
        }


        public IEnumerable<Hotel> GetAllHotels
        {
            get
            {
                return _parkviewDbContext.Hotels;
            }
        }

        public Hotel GetHotelById(int id)
        {
            return _parkviewDbContext.Hotels.FirstOrDefault(hotel => hotel.HotelId == id);
        }

        public IEnumerable<Hotel> SearchHotels(string searchQuery)
        {
            return _parkviewDbContext.Hotels.Where(hotel => hotel.Name.Contains(searchQuery));
        }

        IEnumerable<Hotel> IHotelRepo.SearchHotelsByPriceRange(decimal lowPrice, decimal highPrice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hotel> ListOfHotelsByHotelChain(int id)
        {
            return _parkviewDbContext.Hotels.Where(hotel => hotel.HotelChainId == id);
        }
    }
}
