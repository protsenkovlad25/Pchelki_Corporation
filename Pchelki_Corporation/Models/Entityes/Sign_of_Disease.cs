using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchelki_Corporation.Models.Entityes
{
    public record Sign_of_Disease
    {
        [Key]
        public int Id { get; init; }

        [Required]
        public int SignId { get; set; }
        public Sign Sign { get; set; }

        [Required]
        public int DiseaseId { get; set; }
        public Disease Disease { get; set; }
    }
}
