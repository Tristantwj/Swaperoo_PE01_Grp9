using Swaperoo_PE01_Grp9.Server.Data;
using Swaperoo_PE01_Grp9.Server.IRepository;
using Swaperoo_PE01_Grp9.Server.Models;
using Swaperoo_PE01_Grp9.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Swaperoo_PE01_Grp9.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Category> _categorys;
        private IGenericRepository<Chat> _chats;
        private IGenericRepository<Message> _messages;
        private IGenericRepository<Product> _products;
        private IGenericRepository<Purchase> _purchases;
        private IGenericRepository<Rating> _ratings;
        private IGenericRepository<Report> _reports;
        private IGenericRepository<SubCategory> _subcategorys;
        private IGenericRepository<Swap> _swaps;
        private IGenericRepository<User> _users;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Category> Categorys
            => _categorys ??= new GenericRepository<Category>(_context);
        public IGenericRepository<Chat> Chats
            => _chats ??= new GenericRepository<Chat>(_context);
        public IGenericRepository<Message> Messages
            => _messages ??= new GenericRepository<Message>(_context);
        public IGenericRepository<Rating> Ratings
            => _ratings ??= new GenericRepository<Rating>(_context);
        public IGenericRepository<Product> Products
            => _products ??= new GenericRepository<Product>(_context);
        public IGenericRepository<Purchase> Purchases
            => _purchases ??= new GenericRepository<Purchase>(_context);
        public IGenericRepository<SubCategory> SubCategorys
            => _subcategorys ??= new GenericRepository<SubCategory>(_context);
        public IGenericRepository<Report> Reports
            => _reports ??= new GenericRepository<Report>(_context);
        public IGenericRepository<Swap> Swaps
            => _swaps ??= new GenericRepository<Swap>(_context);
        public IGenericRepository<User> Users
            => _users ??= new GenericRepository<User>(_context);


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                var entityType = entry.Metadata.ClrType;

                // Check if the entity has the necessary properties
                if (entityType.GetProperty("DateUpdated") != null && entityType.GetProperty("UpdatedBy") != null)
                {
                    entry.Property("DateUpdated").CurrentValue = DateTime.Now;
                    entry.Property("UpdatedBy").CurrentValue = user;

                    if (entry.State == EntityState.Added)
                    {
                        entry.Property("DateCreated").CurrentValue = DateTime.Now;
                        entry.Property("CreatedBy").CurrentValue = user;
                    }
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}