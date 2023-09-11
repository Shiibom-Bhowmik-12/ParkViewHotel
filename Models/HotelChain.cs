namespace Parkview.Models
{
    public class HotelChain
    {
        public int HotelChainId { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        //Foreign key to Location
        public int LocationId { get; set; }

        public int DestinationId { get; set; }

        //this is the navigation property for hotels belonging to this chain
        public ICollection<Hotel>? Hotels { get; set; }

        //this is the navigation property for destinations belonging to this chain
        public ICollection<Destination>? Destinations { get; set; }
    }
}