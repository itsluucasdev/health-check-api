using FluentAssertions;
using HealthCheck.Application.HealthCheck;
using HealthCheck.Application.HealthCheck.DTO;
using HealthCheck.Domain.HealthCheck;

namespace HealthCheck.Application.Test;

[TestClass]
public class HealthCheckTest
{
    private IHealthCheckService _healthCheckService;
    
    [TestInitialize]
    public void Setup()
    {
        _healthCheckService = new HealthCheckService();
    }
    
    [TestMethod]
    public void Monitored_Item_Create_Success()
    {
        var monitoredItemInput = new MonitoredItemDTO
        {
            Name = "INTERNO - TESTE CRIACAO",
            Description = "Teste Interno p/ Criação",
            Endpoint = "https://url-test-ping.com/v1/status",
            User = "kurokun",
            Periodicity = 3600,
            DaysOfWeek = [2, 3, 4, 5, 6]
        };

        var expectedResult = new MonitoredItem
        {
            Name = monitoredItemInput.Name,
            Description = monitoredItemInput.Description,
            Endpoint = monitoredItemInput.Endpoint,
            CreatedBy = monitoredItemInput.User
        };

        var result = _healthCheckService.CreateMonitoredApi(monitoredItemInput);
        
        result.Should().BeEquivalentTo(expectedResult);
    }
}