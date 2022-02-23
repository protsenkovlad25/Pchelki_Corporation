using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchelki_Corporation.Models.Entityes
{
    public record Post
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(50, ErrorMessage = "Много букав")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int Salary { get; set; }

        public ICollection<Employee_by_Post> Employees_by_Posts { get; set; }
    }
}
