using GymWebApp.Data.Services;
using GymWebApp.Data.ViewModels;
using GymWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Controllers
{
    [Authorize]
    public class ReservationsController : Controller
    {
        private readonly IReservationsServices _service;

        public ReservationsController(IReservationsServices service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var reservations = Enumerable.Empty<Reservation>();

            if (User.IsInRole("Admin"))
            {
                reservations = await _service.GetAllAsync(m => m.Training, m => m.User);
            }
            else
            {
                var username = User.Identity.Name;
                reservations = await _service.GetAllAsync(m => m.User.UserName == username, m => m.Training, m => m.User);
            }

            return View(reservations);
        }

        public async Task<IActionResult> Details(int id)
        {
            var reservationDetails = await _service.GetReservationByIdAsync(id);
            return View(reservationDetails);
        }

        public async Task<IActionResult> Create()
        {
            var reservationDropDownsValue = await _service.GetReservationDropDownsData();
            ViewBag.Trainings = new SelectList(reservationDropDownsValue.Trainings, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ReservationVM reservation)
        {
            if (!ModelState.IsValid)
            {
                var reservationDropDownsValue = await _service.GetReservationDropDownsData();
                ViewBag.Trainings = new SelectList(reservationDropDownsValue.Trainings, "Id", "Name");
                return View(reservation);
            }

            var username = User.Identity.Name;
            await _service.AddReservationAsync(reservation, username);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var reservationDetails = await _service.GetReservationByIdAsync(id);

            if (reservationDetails == null) return View("NotFound");

            var outcome = new ReservationVM();
            outcome.Id = reservationDetails.Id;
            outcome.ParticipationHour = reservationDetails.ParticipationHour;
            outcome.ParticipationDate = reservationDetails.ParticipationDate;
            outcome.TrainingId = reservationDetails.TrainingId;

            var reservationDropDownsValue = await _service.GetReservationDropDownsData();
            ViewBag.Trainings = new SelectList(reservationDropDownsValue.Trainings, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ReservationVM reservation)
        {
            if (id != reservation.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var reservationDropDownsValue = await _service.GetReservationDropDownsData();
                ViewBag.Trainings = new SelectList(reservationDropDownsValue.Trainings, "Id", "Name");
                return View(reservation);
            }
            await _service.UpdateReservationAsync(reservation);
            return RedirectToAction(nameof(Index));
        }
    }
}
