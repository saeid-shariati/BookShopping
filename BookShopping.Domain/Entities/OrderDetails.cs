using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopping.Domain.Entities
{
    public class OrderDetails
    {
        [Key]
        public Guid OrderProductId { get; set; }
        public Guid ProductId { get; set; }
        public int Count { get; set; }
        public ulong Price { get; set; }
        [ForeignKey("OrderProductId")]
        public OrderProduct OrderProduct { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
