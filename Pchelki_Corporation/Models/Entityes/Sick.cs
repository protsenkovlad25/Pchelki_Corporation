using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchelki_Corporation.Models.Entityes
{
    public record Sick
    {
        [Key]
        public int Id { get; init; }

        [Required]
        public int DiseaseId { get; set; }
        public Disease Disease { get; set; }

        [Required]
        public int FamilyId { get; set; }
        public Family Family { get; set; }
    }
}
