using System;
using System.ComponentModel.DataAnnotations;

namespace GymWebApp.Data.ViewModels
{
    public class ReservationVM
    {
        public int Id { get; set; }

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
