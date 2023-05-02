using Microsoft.EntityFrameworkCore;

using ZenShop.MVC.Application.Abstractions.Context;
using ZenShop.MVC.Core.Domains.Entities;
using ZenShop.MVC.Extentions;

namespace ZenShop.MVC.Infrastructure.Contexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Program).Assembly);
            modelBuilder.ApplySoftDeleteQueryFilter();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
}