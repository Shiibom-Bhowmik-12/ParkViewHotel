namespace Parkview.Models
{
    public interface IHotelChainRepo
    {
        public IEnumerable<HotelChain> AllHotelChain { get; }



        public HotelChain GetHotelChainById(int id);



        public IEnumerable<HotelChain> SearchHotelChainByName(string searchQuery);
    }
}
