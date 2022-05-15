using FitnessWebApp.Data;
using GymWebApp.Data.BaseRepository;
using GymWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Data.Services
{
    public class TrainersService : EntityBaseRepository<Trainer>, ITrainersServices
    {
        public TrainersService(ApplicationDbContext context) : base(context)
        {
        }

    }
}
