using FluentValidation;
using Fs.BusinessLogicLayer;
using Fs.BusinessLogicLayer.Abstract;
using Fs.BusinessLogicLayer.Concrete;
using Fs.BusinessLogicLayer.Dtos;
using Fs.BusinessLogicLayer.ValidationRules;
using Fs.DataAccessLayer.EntityFrameworkCore.Abstract;
using Fs.DataAccessLayer.EntityFrameworkCore.Concrete;
using Fs.DataAccessLayer.EntityFrameworkCore.Contexts;
using FS.ExternalServices.Interfaces;
using FS.ExternalServices.Models;
using FS.ExternalServices.Services;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
string connectionString = builder.Configuration.GetConnectionString("local")!;
builder.Services
    .AddDbContext<FsContext>(options => options.UseSqlServer(connectionString));

var emailConfigurations = builder.Configuration.GetSection("SmtpSetting");
builder.Services.Configure<SmtpSetting>(emailConfigurations);

builder.Services.AddTransient<IEmailService, EmailService>();

builder.Services.AddAutoMapper(typeof(IBusinessRegister));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserDetailRepository, UserDetailRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddScoped<IValidator<CreateUserDto>, CreateUserDtoValidator>();
builder.Services.AddScoped<IValidator<AddProductDto>, AddProductDtoValidator>();





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
    pattern: "{controller=Product}/{action=Index}/{id?}");
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Account}/{action=Register}/{id?}");


app.Run();
