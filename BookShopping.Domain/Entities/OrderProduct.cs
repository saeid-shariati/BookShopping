using BookShopping.Domain.Entities.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopping.Domain.Entities
{
    public class OrderProduct
    {
        [Key]
        public Guid OrderProductId { get; set; }
        public Guid AppUserId { get; set; }
        public DateTime OrderDate { get; set; }
        public ulong OrderPrice { get; set; }
        public string OrderStatus { get; set; }
        public string CellPhone { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string OrderPruductName { get; set; }

        [ForeignKey("AppUserId")]
        public ApplicationUser AppUser { get; set; }

    }
}
