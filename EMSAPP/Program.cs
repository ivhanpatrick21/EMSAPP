using EMSAPP.Data;
using EMSAPP.Repository;
using EMSAPP.Repository.InMemoryRepository;
using EMSAPP.Repository.MsSQL;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// configure asp.net the ef library to connect for a db
builder.Services.AddDbContext<EMSDbContext>();
// DI object is configured by a constructor inject the object defined here 
builder.Services.AddScoped<EMSDbContext, EMSDbContext>();


// if test environment then work with inmemroy object
// else work with database
// asp.net automatically configures objects using DI concept

//builder.Services.AddSingleton<IEMSRepository, EMSInMemoryRepository>();

builder.Services.AddScoped<IEMSRepository, EMSDBRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
