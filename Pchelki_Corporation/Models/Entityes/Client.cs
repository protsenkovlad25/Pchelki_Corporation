using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchelki_Corporation.Models.Entityes
{
    public record Client
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(50, ErrorMessage = "Много букав")]
        public string Second_Name { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Много букав")]
        public string First_Name { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Много букав")]
        public string Father_Name { get; set; }

        public DateTime Date_of_Birth { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Много букав")]
        public string Phone_Number { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Много букав")]
        public string Email { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Много букав")]
        public string Town { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Много букав")]
        public string Street { get; set; }

        [Required]
        public int Home { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}
