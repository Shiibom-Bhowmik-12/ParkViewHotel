namespace Parkview.Models
{
    public class ErrorViewModel
    {
        // sumit
        public string? RequestId { get; set; }

        //shibom
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}