using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchelki_Corporation.Models.Entityes
{
    public record Type_of_Work
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(50, ErrorMessage = "Много букав")]
        public string Name { get; set; }

        public ICollection<Work> Works { get; set; }
    }
}
