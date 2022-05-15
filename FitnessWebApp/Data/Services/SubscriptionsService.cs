using FitnessWebApp.Data;
using GymWebApp.Data.BaseRepository;
using GymWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Data.Services
{
    public class SubscriptionsService : EntityBaseRepository<Subscription>, ISubscriptionsServices
    {
        public SubscriptionsService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
