using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Swaperoo_PE01_Grp9.Server.Configuration.Entities;
using Swaperoo_PE01_Grp9.Server.Models;
using Swaperoo_PE01_Grp9.Shared.Domain;

namespace Swaperoo_PE01_Grp9.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Category> Categorys { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<SubCategory> SubCategorys { get; set; }
        public DbSet<Swap> Swaps { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.Product)
                .WithMany()
                .HasForeignKey(p => p.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            SeedDefaultData(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategorySeedConfiguration());
            modelBuilder.ApplyConfiguration(new ChatSeedConfiguration());
            modelBuilder.ApplyConfiguration(new MessageSeedConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSeedConfiguration());
            modelBuilder.ApplyConfiguration(new UserSeedConfiguration());
            modelBuilder.ApplyConfiguration(new PurchaseSeedConfiguration());
            modelBuilder.ApplyConfiguration(new RatingSeedConfiguration());
            modelBuilder.ApplyConfiguration(new ReportSeedConfiguration());
            modelBuilder.ApplyConfiguration(new SubCategorySeedConfiguration());
            modelBuilder.ApplyConfiguration(new SwapSeedConfiguration());
        }
        private void SeedDefaultData(ModelBuilder modelBuilder)
        {
            var user = new ApplicationUser
            {
                Name = "Frank Ofoedu",
                Region = "North",
                Email = "frankofoedu@blazor.com",
                EmailConfirmed = true
            };

            var passwordHasher = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHasher.HashPassword(user, "Abc123!");

            modelBuilder.Entity<ApplicationUser>().HasData(user);
        }

    }
}