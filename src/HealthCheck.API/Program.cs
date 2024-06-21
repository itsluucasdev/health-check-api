using HealthCheck.Application.Interfaces;
using HealthCheck.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IHealthCheckService, HealthCheckService>();
builder.Services.AddScoped<IMonitoredItemService, MonitoredItemService>();

builder.Services.AddControllers();

builder.Services.AddCors();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();