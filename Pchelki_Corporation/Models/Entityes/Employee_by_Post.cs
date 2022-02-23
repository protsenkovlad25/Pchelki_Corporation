using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchelki_Corporation.Models.Entityes
{
    public record Employee_by_Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required]
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
