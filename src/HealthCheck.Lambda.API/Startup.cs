namespace HealthCheck.Lambda.API;
using HealthCheck.Application.Interfaces;
using HealthCheck.Application.Services;
using Microsoft.OpenApi.Models;


public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddSingleton<IHealthCheckService, HealthCheckService>();
    
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Health Check Serverless API",
                Version = "v1"
            });
        });

        services.AddCors();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        
        app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyOrigin();
                c.AllowAnyMethod();
            }
        );

        app.UseHttpsRedirection();

        app.UseRouting();
        
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Welcome to running ASP.NET Core on AWS Lambda");
            });
        });
    }
}