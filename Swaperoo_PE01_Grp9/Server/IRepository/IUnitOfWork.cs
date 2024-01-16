using Swaperoo_PE01_Grp9.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swaperoo_PE01_Grp9.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Category> Categorys { get; }
        IGenericRepository<Chat> Chats { get; }
        IGenericRepository<Message> Messages { get; }
        IGenericRepository<Product> Products { get; }
        IGenericRepository<Purchase> Purchases { get; }
        IGenericRepository<Rating> Ratings { get; }
        IGenericRepository<Report> Reports { get; }
        IGenericRepository<SubCategory> SubCategorys { get; }
        IGenericRepository<Swap> Swaps { get; }
        IGenericRepository<User> Users { get; }

    }
}