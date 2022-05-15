using GymWebApp.Data.BaseRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Models
{
    public class Trainer : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Prenume")]
        [Required(ErrorMessage = "Caseta 'Prenume' trebuie completată!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Caseta 'Prenumele' trebuie să conțină între 3 și 20 caractere!")]
        public string FirstName { get; set; }

        [Display(Name = "Nume")]
        [Required(ErrorMessage = "Caseta 'Nume' trebuie completată!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Caseta 'Nume' trebuie să conțină între 3 și 20 caractere!")]
        public string LastName { get; set; }

        [Display(Name = "Poză de profil")]
        public string ProfilePicture { get; set; }

        [Display(Name = "Biografie")]
        [Required(ErrorMessage = "Caseta 'Biografie' trebuie completată!")]
        public string Biography { get; set; }
    }
}
