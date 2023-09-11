namespace Parkview.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        //this is the navigation property for the hotel 
        public IEnumerable<Hotel> Hotels { get; set; }
    }
}