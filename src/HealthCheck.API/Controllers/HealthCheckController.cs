using HealthCheck.Application.HealthCheck.DTO;
using HealthCheck.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HealthCheck.API.Controllers;

[Controller]
[Route("[controller]")]
public class HealthCheckController(IHealthCheckService healthCheckService) : ControllerBase
{
    [HttpPost(Name = $"{nameof(CreateHelthCheck)}")]
    public IActionResult CreateHelthCheck(MonitoredItemDTO dto)
    {
        try
        {
            return Ok(healthCheckService.CreateMonitoredApi(dto));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}