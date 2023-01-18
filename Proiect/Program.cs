using Proiect.Data;
using Microsoft.EntityFrameworkCore;
using Proiect.Helpers.Extensions;
using Proiect.Helpers;
using Proiect.Helpers.Seeders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRepositories();
builder.Services.AddServices();

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();
SeedData(app);


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();

void SeedData(IHost app)
{
  var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
  using (var scope = scopedFactory.CreateScope())
  {
    var service = scope.ServiceProvider.GetService<EmployeesSeeder>();
    service.SeedInitialStudents();
  }
}
