using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces;
using Services.Services;
using System.Reflection;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<InventoryManagementContext>(options => 
   options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));

builder.Services.AddAutoMapper(Assembly.Load("Services"));

builder.Services.AddScoped<IEquipmentService, EquipmentService>();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<ITypeService, TypeService>();
builder.Services.AddScoped<IPositionService, PositionService>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   app.UseSwagger();
   app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
