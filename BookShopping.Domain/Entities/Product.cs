using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopping.Domain.Entities
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string BarCode { get; set; }
        public ulong Price { get; set; }
        public Guid CategoryId { get; set; }
        public string? Picture { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
