using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchelki_Corporation.Models.Entityes
{
    public record Equipment
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(50, ErrorMessage = "Много букав")]
        public string Name { get; set; }

        public int Amount { get; set; }

        public ICollection<Tabel> Tabels { get; set; }
    }
}
