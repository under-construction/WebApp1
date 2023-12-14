using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Entities;
using WebApp.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors(opt => { opt.AddPolicy("default", policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()); });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<PersonContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("WebAppNew")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepository<Person>, PersonRepository>();

var app = builder.Build();

//var host = new WebHostBuilder()
//    .UseKestrel()
//    .UseContentRoot(Directory.GetCurrentDirectory())
//    .UseIISIntegration()
//    .Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("default");

app.MapControllers();

app.Run();
