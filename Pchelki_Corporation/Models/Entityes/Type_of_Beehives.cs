using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchelki_Corporation.Models.Entityes
{
    public record Type_of_Beehives
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(50, ErrorMessage = "Много букав")]
        public string Name { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Много букав")]
        public string Size_Beehive { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Много букав")]
        public string Size_Frame { get; set; }

        [Required]
        public int Amount_Frame { get; set; }

        public ICollection<Family> Families { get; set; }
    }
}
