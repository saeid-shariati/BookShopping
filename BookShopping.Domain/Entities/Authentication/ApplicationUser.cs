using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopping.Domain.Entities.Authentication
{
    public class ApplicationUser:IdentityUser<Guid>
    {
        [Required]
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string CellPhone { get; set; }

        [NotMapped]
        public string Role { get; set; }

    }
}
