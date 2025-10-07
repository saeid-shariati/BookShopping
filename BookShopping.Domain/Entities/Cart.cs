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
    public class Cart
    {
        [Key]
        public Guid CartId { get; set; }
        public Guid AppUserId { get; set; }
        public Guid ProductId { get; set; }
        public ushort Count { get; set; }
        public ulong Price { get; set; }

        [ForeignKey("AppUserId")]
        public ApplicationUser AppUser { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
