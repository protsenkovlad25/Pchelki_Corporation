using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchelki_Corporation.Models.Entityes
{
    public record Tabel
    {
        [Key]
        public int Id { get; init; }

        [Required]
        public int WorkId { get; set; }
        public Work Work { get; set; }

        [Required]
        public int FamilyId { get; set; }
        public Family Family { get; set; }

        [Required]
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }

        [Required]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Required]
        public int RoomId { get; set; }
        public Room Room { get; set; }

        public int Amount_Product { get; set; }

        [Required]
        public DateTime Date_Event { get; set; }
    }
}
