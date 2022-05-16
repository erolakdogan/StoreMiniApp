using Microsoft.EntityFrameworkCore;
using StoreMiniApp.API.Domain.Data;
using StoreMiniApp.API.Domain.Interfaces;
using StoreMiniApp.API.Domain.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

IWebHostEnvironment environment = builder.Environment;

// Add services to the container.

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<StoreMiniAppDbContext>(x => x.UseSqlServer(connectionString));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//mapping
builder.Services.AddAutoMapper(typeof(Program).Assembly);

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
