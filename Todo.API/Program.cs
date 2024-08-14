using Microsoft.EntityFrameworkCore;
using Todo.Infrastructure.Context;
using Todo.Infrastructure.DI;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

const string myAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddInfrastructure(configuration);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();






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
