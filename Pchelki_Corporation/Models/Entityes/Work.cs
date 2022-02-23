using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchelki_Corporation.Models.Entityes
{
    public record Work
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(100, ErrorMessage = "Много букав")]
        public string Name { get; set; }
        
        [Required]
        public int Type_of_WorkId { get; set; }
        public Type_of_Work Type_of_Work { get; set; }

        public ICollection<Tabel> Tabels { get; set; }
    }
}
