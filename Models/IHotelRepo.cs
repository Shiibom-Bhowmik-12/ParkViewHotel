namespace Parkview.Models
{
    public interface IHotelRepo
    {
        public IEnumerable<Hotel> GetAllHotels { get; }

        public Hotel GetHotelById(int id);

        public IEnumerable<Hotel> SearchHotels(string searchQuery);

        public IEnumerable<Hotel> SearchHotelsByPriceRange(decimal lowPrice, decimal highPrice);

        public IEnumerable<Hotel> ListOfHotelsByHotelChain(int id);
    }
}
