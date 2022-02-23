using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchelki_Corporation.Models.Entityes
{
    public record Bee_Garden
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(50, ErrorMessage = "Много букав")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Много букав")]
        public string Town { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Много букав")]
        public string Street { get; set; }

        [Required]
        public int Home { get; set; }

        [MaxLength(30, ErrorMessage = "Много букав")]
        public string Square { get; set; }

        public ICollection<Family> Families { get; set; }
    }
}
