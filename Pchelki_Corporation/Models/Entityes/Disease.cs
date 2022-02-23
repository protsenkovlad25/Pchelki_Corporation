using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchelki_Corporation.Models.Entityes
{
    public record Disease
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(50, ErrorMessage = "Много букав")]
        public string Name { get; set; }

        public ICollection<Sign_of_Disease> Signs_of_Diseases { get; set; }

        public ICollection<Healing_of_Disease> Healings_of_Diseases { get; set; }

        public ICollection<Sick> Sicks { get; set; }
    }
}
