using FluentAssertions;
using HealthCheck.Application.HealthCheck;
using HealthCheck.Application.HealthCheck.DTO;
using HealthCheck.Domain.Enums;
using HealthCheck.Domain.HealthCheck;

namespace HealthCheck.Application.Test;

[TestClass]
public class MonitoredItemTest
{
    [TestMethod]
    [Description("Nome do Teste")]
    public void CreateMonitoredItemTest()
    {
        var inputDTO = new MonitoredItemDTO
        {
            Name = "Test - Mofardini",
            Description = "Test Mofardini API",
            Endpoint = "http://url-test.com",
            HttpMethod = HttpMethod.Post,
            User = "mofardlu",
            Periodicity = 3600,
            DaysOfWeek =
            [
                2,3,4,5,6
            ],
            AuthenticationType = AuthenticationTypeEnum.None
        };

        var expectedResult = new MonitoredItem
        {
            Schema = "API",
            Hash = Guid.NewGuid().ToString(),
            Name = inputDTO.Name,
            Description = inputDTO.Description,
            Endpoint = inputDTO.Endpoint,
            HttpMethod = inputDTO.HttpMethod.ToString(),
            CreatedAt = DateTime.Now,
            UpdatedAt = null,
            CreatedBy = inputDTO.User,
            UpdatedBy = null,
            LastStatus = null,
            LastRun = null,
            AuthenticationType = (int) inputDTO.AuthenticationType
        };

        var healthCheckService = new HealthCheckService();
        var result = healthCheckService.CreateMonitoredApi(inputDTO);

        result.Should().Be(expectedResult);
    }
}