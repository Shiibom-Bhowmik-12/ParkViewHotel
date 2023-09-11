using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Parkview.Models;
using Parkview.ViewModels;

namespace Parkview.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationRepo _destination;

        public DestinationController(IDestinationRepo destinationRepo)
        {
            _destination = destinationRepo;
        }


        public IActionResult Index()
        {
            var destinationList = new DestinationListViewModel(_destination.GetDestinationList, _destination.TotalDestinations);
            return View(destinationList);
        }

        
        public IActionResult Detail(int destinationId)
        {
            var destination = _destination.GetDestinationById(destinationId);
            return View(destination);
        }

        public IActionResult DestinationDetailWithHotel(int destinationId)
        {
            var destination = _destination.GetDestinationById(destinationId);
            return View(destination);
        }
    }
}
