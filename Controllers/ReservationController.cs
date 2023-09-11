using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Parkview.Models;
using Parkview.ViewModels;
using Stripe.Checkout;
using Stripe;
using Stripe.BillingPortal;
using System.Runtime.InteropServices;

namespace Parkview.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IRoomRepo _roomRepo;
        private readonly IBookingRepo _bookingRepo;
        public ReservationController(IRoomRepo roomRepo, IBookingRepo bookingRepo)
        {
            _roomRepo = roomRepo;
            _bookingRepo = bookingRepo;
        }

        public IActionResult Index(int roomId)
        {
            var room = _roomRepo.GetRoomById(roomId);
            ViewData["Room"] = room;
            return View();
        }
        public IActionResult ReservationByUser(string userId)
        {
            var userReservation = _bookingRepo.BookingListByUser(userId);
            return View(userReservation);
        }


        [Authorize]
        [HttpPost]
        public IActionResult ReservationStatus(int roomId, string userid, Booking bookingUser)
        {
            var rooms = _roomRepo.GetRoomById(roomId);
            bookingUser.BookingTotal = CalculateBookingTotal(roomId, bookingUser);
            bookingUser.RoomId = roomId;
            bookingUser.UserId = userid;
            _bookingRepo.SubmitBooking(bookingUser);
            var bkView1 = new BookingViewModel(bookingUser, rooms);
            return View(bkView1);
        }

        public IActionResult ReservationFail()
        {
            return View();
        }

        public IActionResult CancelReservation(int Id)
        {
            var booking = _bookingRepo.GetBooking(Id);
            _bookingRepo.CancelBooking(Id);
            return RedirectToAction("Index","Home");
        }

        public IActionResult ReservationSuccess()
        {
            return View();
        }

        public decimal CalculateBookingTotal(int roomId, Booking bookingUser)
        {
            var rooms = _roomRepo.GetRooms.FirstOrDefault(room => room.RoomId == roomId);
            decimal gst = 0;
            decimal total = 0;
            var roomType = rooms.RoomType;
            var totalrooms = bookingUser.NoOfRooms;
            var isChildAbove5 = bookingUser.NoOfChildrenAbove5 > 0 ? 1 : 0;
            if (roomType == "Deluxe")
            {
                total = (8000 + 2500 * isChildAbove5) * totalrooms * (CalculateStay(bookingUser.CheckInDate, bookingUser.CheckOutDate));
            }
            else if (roomType == "Super Deluxe")
            {
                total = (14000 + 2500 * isChildAbove5) * totalrooms * (CalculateStay(bookingUser.CheckInDate, bookingUser.CheckOutDate));
            }
            else if (roomType == "Executive")
            {
                total = (20000 + 2500 * isChildAbove5) * totalrooms * (CalculateStay(bookingUser.CheckInDate, bookingUser.CheckOutDate));
            }
            else
            {
                total = (28000 + 2500 * isChildAbove5) * totalrooms * (CalculateStay(bookingUser.CheckInDate, bookingUser.CheckOutDate));
            }
            gst = (total) * 0.18M;
            total += gst;
            return total;
        }

         public decimal CalculateStay(DateTime checkin, DateTime checkout)
         {
            var timeSpan1 = new TimeSpan(checkin.Day, checkin.Hour, checkin.Minute, checkin.Second);
            var timeSpan2 = new TimeSpan(checkout.Day, checkout.Hour, checkout.Minute, checkout.Second);
            decimal diff = timeSpan2.Days - timeSpan1.Days;
            return diff;
         }


        public IActionResult StripePayment(decimal totalamt)
        {
            var domain = "https://localhost:7033/";

            // Retrieve the total amount from your booking logic or TempData
            decimal totalAmountInCents = totalamt * 100; // Example: 1000 (₹10.00)

            var minimumAmountInCents = 50; // Minimum amount in cents (₹0.50)
            
            if (totalAmountInCents < minimumAmountInCents)
            {
                totalAmountInCents = minimumAmountInCents;
            }

            var options = new Stripe.Checkout.SessionCreateOptions
            {
                SuccessUrl = domain + $"Reservation/ReservationSuccess", // Adjust the URL accordingly
                CancelUrl = domain + $"Reservation/ReservationFail", // Adjust the URL accordingly
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            UnitAmount = (long)totalAmountInCents, // Total amount in cents
                            Currency = "inr",
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = "Reservation Payment", // Adjust the name as needed
                            }
                        },
                        Quantity = 1, // Quantity is 1 for the total amount
                    }
                },
                Mode = "payment",
            };

            var service = new Stripe.Checkout.SessionService();
            var session = service.Create(options);

            TempData["sessionId"] = session.Id;

            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }

    }
}




