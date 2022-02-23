using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchelki_Corporation.Models.Entityes
{
    public record Family
    {
        [Key]
        public int Id { get; init; }

        [MaxLength(50, ErrorMessage = "Много букав")]
        public string Reproduction { get; set; }

        public int Productivity { get; set; }

        [Required]
        public int Bee_GardenId { get; set; }
        public Bee_Garden Bee_Garden { get; set; }

        [Required]
        public int Type_of_BeesId { get; set; }
        public Type_of_Bees Type_of_Bees { get; set; }

        [Required]
        public int Type_of_BeehivesId { get; set; }
        public Type_of_Beehives Type_of_Beehives { get; set; }

        public ICollection<Sick> Sicks { get; set; }

        public ICollection<Tabel> Tabels { get; set; }
    }
}
