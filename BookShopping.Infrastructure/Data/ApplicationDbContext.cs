using BookShopping.Domain.Entities;
using BookShopping.Domain.Entities.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShopping.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Company> Companies { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUserLogin<Guid>>(entity =>
            {
                entity.HasKey(login => new { login.ProviderKey, login.LoginProvider });
            });
            builder.Entity<IdentityUserRole<Guid>>(entity =>
            {
                entity.HasKey(role => new { role.UserId, role.RoleId });
            });
            builder.Entity<IdentityUserClaim<Guid>>(entity =>
            {
                entity.HasKey(claim => claim.Id);
            });
        }

    }
}
