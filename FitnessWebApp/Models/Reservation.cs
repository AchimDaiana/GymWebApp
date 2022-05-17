using GymWebApp.Data.BaseRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Models
{
    public class Reservation : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Numele și prenume")]
        public string Name { get; set; }

        public string Email { get; set; }

        [Display(Name = "Ora participării")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public DateTime ParticipationHour { get; set; }

        [Display(Name = "Data participării")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ParticipationDate { get; set; }

        //relatia cu clasele
        public int TrainingId { get; set; }
        [Display(Name = "Antrenamentul rezervat")]
        public Training Training { get; set; }
    }
}
