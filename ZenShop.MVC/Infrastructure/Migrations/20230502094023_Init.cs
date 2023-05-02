using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZenShop.MVC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ShortDescription = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedBy", "Description", "IsDeleted", "Name", "ShortDescription", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("18f93da0-a3a0-4fc1-175d-08db4af14078"), null, null, false, "Samsung S23", null, null, null },
                    { new Guid("296e41a4-f3f1-421a-175e-08db4af14078"), null, null, false, "Samsung S23 Ultra", null, null, null },
                    { new Guid("51c46552-8025-48e1-1758-08db4af14078"), null, null, false, "IPhone 12 Pro", null, null, null },
                    { new Guid("62efffd4-b397-4010-1759-08db4af14078"), null, null, false, "IPhone 12 Pro Max", null, null, null },
                    { new Guid("6cc0aae4-8f62-4873-175b-08db4af14078"), null, null, false, "Samsung S22", null, null, null },
                    { new Guid("b1047a1b-c9bc-46ae-1756-08db4af14078"), null, null, false, "IPhone 12 Mini", null, null, null },
                    { new Guid("d8117ff9-3f6d-4ca0-175c-08db4af14078"), null, null, false, "Samsung S22 Ultra", null, null, null },
                    { new Guid("eb20a719-7ed3-49c3-172a-08db4af14078"), null, null, false, "IPhone 12", null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
