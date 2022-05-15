using GymWebApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Data.ViewModels
{
    public class TrainingVM
    {
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

        public List<int> ReservationsIds { get; set; }

        [Display(Name = "Selectează Antrenorul")]
        [Required(ErrorMessage = "Caseta 'Antrenor' trebuie completată!")]
        public int TrainerId { get; set; }

        [Display(Name = "Selectează Abonamentul")]
        [Required(ErrorMessage = "Caseta 'Abonament' trebuie completată!")]
        public int SubscriptionId { get; set; }
    }
}
