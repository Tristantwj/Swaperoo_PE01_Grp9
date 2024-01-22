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
            var passwordHasher = new PasswordHasher<ApplicationUser>();

            // Inside SeedDefaultData method
            var user = new ApplicationUser
            {
                Id = "2bf0d5d5-7691-418f-b2f7-266c7467a0b0",
                UserName = "frankofoedu@blazor.com", // Make sure to set a unique UserName
                NormalizedUserName = "FRANKOFOEDU@BLAZOR.COM", // Set the normalized value
                Email = "frankofoedu@blazor.com",
                NormalizedEmail = "FRANKOFOEDU@BLAZOR.COM", // Set the normalized value
                EmailConfirmed = true
            };
            user.PasswordHash = passwordHasher.HashPassword(user, "Abc123!");

            var user2 = new ApplicationUser
            {
                Id = "2bf0d5d5-7691-418f-b2f7-266c7467a0b1",
                UserName = "john@blazor.com", // Make sure to set a unique UserName
                NormalizedUserName = "JOHN@BLAZOR.COM", // Set the normalized value
                Email = "john@blazor.com",
                NormalizedEmail = "JOHN@BLAZOR.COM", // Set the normalized value
                EmailConfirmed = true
            };
            user2.PasswordHash = passwordHasher.HashPassword(user2, "Abc123!");

            var user3 = new ApplicationUser
            {
                Id = "2bf0d5d5-7691-418f-b2f7-266c7467a0b2",
                UserName = "alice@blazor.com", // Make sure to set a unique UserName
                NormalizedUserName = "ALICE@BLAZOR.COM", // Set the normalized value
                Email = "alice@blazor.com",
                NormalizedEmail = "ALICE@BLAZOR.COM", // Set the normalized value
                EmailConfirmed = true
            };
            user3.PasswordHash = passwordHasher.HashPassword(user3, "Abc123!");

            modelBuilder.Entity<ApplicationUser>().HasData(user, user2, user3);

        }

    }
}