using GymWebApp.Data.BaseRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Models
{
    public class Subscription : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nume")]
        [Required(ErrorMessage = "Caseta 'Nume' trebuie completată!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Caseta 'Nume' trebuie să conțină între 3 și 50 caractere!")]
        public string Name { get; set; }

        [Display(Name = "Valabilitate")]
        [Required(ErrorMessage = "Caseta 'Valabilitate' trebuie completată!")]
        public string Validity { get; set; }

        [Display(Name = "Imagine")]
        public string Picture { get; set; }

        [Display(Name = "Preț")]
        [Required(ErrorMessage = "Caseta 'Preț' trebuie completată!")]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Descriere")]
        [Required(ErrorMessage = "Caseta 'Descriere' trebuie completata!")]
        public string Description { get; set; }
    }
}
