using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using ZenShop.MVC.Core.Domains.Entities;

namespace ZenShop.MVC.Infrastructure.EntityConfigurations
{
    public class ProductTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable($"{nameof(Product)}s");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            //builder.Property(x => x.CreatedAt).HasDefaultValueSql("getdate()");// for SQL server
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("date('now')");// for SQLite

            builder.HasData(new[]
            {
                new Product("IPhone 12"),
                new Product("IPhone 12 Mini"),
                new Product("IPhone 12 Pro"),
                new Product("IPhone 12 Pro Max"),
                new Product("Samsung S22"),
                new Product("Samsung S22 Ultra"),
                new Product("Samsung S23"),
                new Product("Samsung S23 Ultra"),
            });
        }
    }
}