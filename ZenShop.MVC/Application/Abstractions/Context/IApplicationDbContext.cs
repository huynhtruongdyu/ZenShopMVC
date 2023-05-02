using Microsoft.EntityFrameworkCore;

using ZenShop.MVC.Core.Domains.Entities;

namespace ZenShop.MVC.Application.Abstractions.Context
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
    }
}