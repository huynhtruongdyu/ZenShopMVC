using Microsoft.EntityFrameworkCore;

using ZenShop.MVC.Application.Abstractions.Context;
using ZenShop.MVC.Infrastructure.Contexts;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllersWithViews();
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
    {
        string defaultConnection = builder.Configuration.GetConnectionString("DefaultConnection");
        options.UseSqlite(defaultConnection);
    });
    builder.Services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
}

var app = builder.Build();
{
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }
    app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseRouting();
    app.UseAuthorization();
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    app.Run();
}