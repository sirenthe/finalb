using EduHome.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:Default"]);
});






var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
  name: "areas",
  pattern: "{area:exists}/{controller=DashBoard}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{Id?}"
    );



app.Run();
