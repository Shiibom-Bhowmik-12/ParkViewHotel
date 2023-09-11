namespace Parkview.Models
{
    public class HotelChainDbRepo : IHotelChainRepo
    {
        private readonly ParkviewDbContext _parkviewDbContext;




        public HotelChainDbRepo(ParkviewDbContext parkviewDbContext)
        {
            _parkviewDbContext = parkviewDbContext;
        }



        public IEnumerable<HotelChain> AllHotelChain
        {
            get
            {
                return _parkviewDbContext.HotelChains;
            }
        }



        public IEnumerable<HotelChain> SearchHotelChainByName(string searchQuery)
        {
            return _parkviewDbContext.HotelChains.Where(s => s.Name.Contains(searchQuery));
        }



        public HotelChain GetHotelChainById(int id)
        {
            return _parkviewDbContext.HotelChains.Single(hotelchain => hotelchain.HotelChainId == id);
        }
    }
}
