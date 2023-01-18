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
builder.Services.AddSeeders();
builder.Services.AddUtils();

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();
SeedData(app);

if (!app.Environment.IsDevelopment())
{
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAuthorization();

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
