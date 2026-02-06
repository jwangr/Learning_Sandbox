using Microsoft.EntityFrameworkCore;
using PtsApi.Models;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PatientContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PatientContext") ?? throw new InvalidOperationException("Connection string 'PatientContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<PtContext>(opt =>
    opt.UseInMemoryDatabase("Patients"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUi(options =>
    {
        options.DocumentPath = "/openapi/v1.json"; // localhost:7086/openapi/v1.json shows OpenAPI specifications
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
