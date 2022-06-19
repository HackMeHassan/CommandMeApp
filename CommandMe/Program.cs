using CommandMe.Data.EntityFrameworkCore;
using CommandMe.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//if anytime sooner or later the becuase of huge implemenation chqanges we decide to change our Mock Repo class we
//simply create a new repository class and pass it to the AddScoped method of the services
builder.Services.AddScoped<ICommandMeRepo, CommandMeRepo>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<CommandMeContext>(options =>
                  options.UseSqlServer("name=ConnectionStrings:CommandMeConnection"));

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
