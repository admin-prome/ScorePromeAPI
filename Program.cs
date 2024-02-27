using Microsoft.EntityFrameworkCore;
using ScorePromeAPI.APIKey;
using ScorePromeAPI.Business.ScoreNosis;
using ScorePromeAPI.Models.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = Environment.GetEnvironmentVariable("BasesNegativas");
builder.Services.AddDbContext<BasesNegativasContext>(options =>
{
    Console.WriteLine($"Cadena de Conexión: {connectionString}");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

builder.Services.AddScoped<DatosNosisBusiness, DatosNosisBusiness>();

var validApiKey = Environment.GetEnvironmentVariable("APIKeyBN");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<APIKeyMiddleware>(validApiKey);

app.MapControllers();

app.Run();
