using Microsoft.EntityFrameworkCore;
using MNJ_CRUD_OPERATION_FINAL.Data;
using MNJ_CRUD_OPERATION_FINAL.Models;
using MNJ_CRUD_OPERATION_FINAL.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<IGenericRepo<EmployeeModel>, GenericRepo<EmployeeModel>>();

builder.Services.AddTransient<IGenericRepo<AddressModel>, GenericRepo<AddressModel>>();

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
    pattern: "{controller=PersonalDetail}/{action=Index}/{id?}");

app.Run();
