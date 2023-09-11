using Microsoft.AspNetCore.Mvc;
using Parkview.Models;
using Parkview.ViewModels;
using System.Diagnostics;

namespace Parkview.Controllers
{
    public class HomeController : Controller
    {
        private readonly ParkviewDbContext _parkviewDbContext;
        private readonly IDestinationRepo _destination;

        public HomeController(ParkviewDbContext parkviewDbContext,IDestinationRepo destinationRepo)
        {
            _parkviewDbContext = parkviewDbContext;
            _destination = destinationRepo;
        }

        public IActionResult Index()
        {
            var destinationList = new DestinationListViewModel(_destination.GetDestinationList, _destination.TotalDestinations);
            return View(destinationList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Dining()
        {
            return View();
        }

        public IActionResult Wedding()
        {
            return View();
        }

        public IActionResult Experiences()
        {
            return View();
        }

        public IActionResult Offers()
        {
            return View();
        }

        public IActionResult SiteMap()
        {
            return View();
        }

        public IActionResult FlyerPartner()
        {
            return View();
        }

        public IActionResult TermsOfUse()
        {
            return View();
        }

        public IActionResult Blogs()
        {
            return View();
        }

        public IActionResult Careers()
        {
            return View();
        }

        public IActionResult FAQs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}