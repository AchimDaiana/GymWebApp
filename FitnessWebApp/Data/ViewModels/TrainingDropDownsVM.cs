using GymWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Data.ViewModels
{
    public class TrainingDropDownsVM
    {
        public TrainingDropDownsVM()
        {
            Trainers = new List<Trainer>();
            Subscriptions = new List<Subscription>();
        }
        public List<Trainer> Trainers { get; set; }

        public List<Subscription> Subscriptions { get; set; }
    }
}
