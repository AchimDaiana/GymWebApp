using GymWebApp.Data.BaseRepository;
using GymWebApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Models
{
    public class Training : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nume")]
        [Required(ErrorMessage = "Caseta 'Nume' trebuie completată!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Caseta 'Prenumele' trebuie să conțină între 3 și 50 caractere!")]
        public string Name { get; set; }

        [Display(Name = "Descriere")]
        [Required(ErrorMessage = "Caseta 'Descriere' trebuie completată!")]
        public string Description { get; set; }

        [Display(Name = "Imagine")]
        public string Picture { get; set; }

        [Display(Name = "Selectează Ora începerii")]
        [Required(ErrorMessage = "Caseta 'Ora începerii' trebuie completată!")]
        public DateTime StartHour { get; set; }

        [Display(Name = "Selectează Ora finalizării")]
        [Required(ErrorMessage = "Caseta 'Ora finalizării' trebuie completată!")]
        public DateTime FinishHour { get; set; }

        [Display(Name = "Selectează Categoria antrenamentului")]
        [Required(ErrorMessage = "Caseta 'Categoria antrenamentului' trebuie completată!")]
        public TrainingCategory Category { get; set; }

        //relatia cu rezervarile
        public List<Reservation> Reservations { get; set; }


        //relatia cu antrenorii
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }

        //relatia cu abonamentele
        public int SubscriptionId { get; set; }
        public Subscription Subscription { get; set; }
    }
}
