using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchelki_Corporation.Models.Entityes
{
    public record Product_Sold
    {
        [Key]
        public int Id { get; init; }

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Required]
        public int SaleId { get; set; }
        public Sale Sale { get; set; }

        [Required]
        public int Amount { get; set; }
    }
}
