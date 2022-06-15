using FitnessWebApp.Data;
using GymWebApp.Data.BaseRepository;
using GymWebApp.Data.ViewModels;
using GymWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GymWebApp.Data.Services
{
    public class ReservationsService : EntityBaseRepository<Reservation>, IReservationsServices
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ReservationsService(ApplicationDbContext context, UserManager<IdentityUser> userManager) : base(context)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task AddReservationAsync(ReservationVM data)
        {
            var newReservation = new Reservation();
            newReservation.Name = data.Name;
            newReservation.Email = data.Email;
            newReservation.ParticipationHour = data.ParticipationHour;
            newReservation.ParticipationDate = data.ParticipationDate;
            newReservation.TrainingId = data.TrainingId;

            await _context.Reservations.AddAsync(newReservation);
            await _context.SaveChangesAsync();
        }

        public async Task <Reservation> GetReservationByIdAsync(int id)
        {
/*            var userId = _userManager.GetUserId();
            var user = await _userManager.FindByEmailAsync(User.Identity.UserName);
            int userId = User.Identity.GetUserId<int>();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);*/

                       // var userEmail = userEmail.FindFirstValue(ClaimTypes.Email); // will give the user's Email
                        var reservationDetails = await _context.Reservations
                            .Include(b => b.Training)//.Where(n => n.Name == )//emailul utilizatorului conectat
                            .FirstOrDefaultAsync(m => m.Id == id);

                        return reservationDetails;
                    }

            public async Task<ReservationDropDownsVM> GetReservationDropDownsData()
        {
            var outcome = new ReservationDropDownsVM();
            outcome.Trainings = await _context.Trainings.OrderBy(m => m.Name).ToListAsync();
            return outcome;
        }

        public async Task UpdateReservationAsync(ReservationVM data)
        {
            var dbReservation = await _context.Reservations.FirstOrDefaultAsync(m => m.Id == data.Id);
            if (dbReservation != null)
            {
                var newReservation = new Reservation();
                dbReservation.Name = data.Name;
                dbReservation.Email = data.Email;
                dbReservation.ParticipationHour = data.ParticipationHour;
                dbReservation.ParticipationDate = data.ParticipationDate;
                dbReservation.TrainingId = data.TrainingId;

                await _context.SaveChangesAsync();
            }

        }
    }
}
