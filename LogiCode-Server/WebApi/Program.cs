using AutoMapper;
using Core.Mapping;
using Data;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Service.c;
using Service.Interfaces;
using Service.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddScoped<IStudentRepository,StudentRepository>();
builder.Services.AddScoped<IUserService,UserService>(); 
builder.Services.AddScoped<IStudentService,StudentService>();
builder.Services.AddDbContext<LogiCodeDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAutoMapper(typeof(MappingProfile));

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
