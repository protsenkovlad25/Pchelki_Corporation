using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchelki_Corporation.Models.Entityes
{
    public record Sale
    {
        [Key]
        public int Id { get; init; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public DateTime Date { get; set; }

        public ICollection<Product_Sold> Products_Sold { get; set; }
    }
}
