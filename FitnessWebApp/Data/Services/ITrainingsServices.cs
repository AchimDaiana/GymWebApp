using GymWebApp.Data.BaseRepository;
using GymWebApp.Data.ViewModels;
using GymWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Data.Services
{
    public interface ITrainingsServices : IEntityBaseRepository<Training>
    {
        Task<Training> GetTrainingByIdAsync(int id);

        Task<TrainingDropDownsVM> GetTrainingDropDownsData();

        Task AddTrainingAsync(TrainingVM data);

        Task UpdateTrainingAsync(TrainingVM data);
    }
}
