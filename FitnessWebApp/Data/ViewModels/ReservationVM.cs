using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Data.ViewModels
{
    public class ReservationVM
    {
        public int Id { get; set; }

        [Display(Name = "Numele și prenume")]
        [Required(ErrorMessage = "Caseta 'Numele și prenume' trebuie completată!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Caseta 'Numele și prenume' trebuie să conțină între 3 și 50 de caractere!")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Caseta 'Email' trebuie completatâ!")]
        public string Email { get; set; }

        [Display(Name = "Selectează Ora participării")]
        [Required(ErrorMessage = "Caseta 'Ora participării' trebuie completată!")]
        public DateTime ParticipationHour { get; set; }

        [Display(Name = "Selectează Data participării")]
        [Required(ErrorMessage = "Caseta 'Data participării' trebuie completată!")]
        public DateTime ParticipationDate { get; set; }

        [Display(Name = "Selectează Antrenamentul")]
        [Required(ErrorMessage = "Caseta 'Antrenament' trebuie completată!")]
        public int TrainingId { get; set; }
    }
}
