namespace Parkview.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }

        public string? DestinationName { get; set; }

        public string? DestinationState { get; set; }

        public string? DestinationDescription { get; set; }

        public string? DestinationDetailedDescription { get; set; }

        public decimal DestinationPrice { get; set; } 

        public string? DestinationImageUrl { get; set; }

        public string? DestinationVideoUrl { get; set; }

        public int DestLocationId { get; set; }

        public int? HotelChainId { get; set; }
    }
}
