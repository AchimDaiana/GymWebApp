using GymWebApp.Data.BaseRepository;
using GymWebApp.Data.ViewModels;
using GymWebApp.Models;
using System.Threading.Tasks;

namespace GymWebApp.Data.Services
{
    public interface IReservationsServices : IEntityBaseRepository<Reservation>
    {
        Task<Reservation> GetReservationByIdAsync(int id);
        Task<ReservationDropDownsVM> GetReservationDropDownsData();
        Task AddReservationAsync(ReservationVM data, string username);
        Task UpdateReservationAsync(ReservationVM data);
    }
}
