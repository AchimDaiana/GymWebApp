using GymWebApp.Data.BaseRepository;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace GymWebApp.Models
{
    public class Reservation : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

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
