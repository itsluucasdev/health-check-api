using FluentAssertions;
using HealthCheck.Application.HealthCheck;
using HealthCheck.Application.HealthCheck.DTO;
using HealthCheck.Application.Services;
using HealthCheck.Domain.Enums;
using HealthCheck.Domain.HealthCheck;
using HealthCheck.Utils.CronExpression;

namespace HealthCheck.Application.Test;

[TestClass]
public class MonitoredItemTest
{
    [TestMethod]
    public void CreateMonitoredItemTest()
    {
        var inputDTO = new MonitoredItemDTO
        {
            Name = "Test - Mofardini",
            Description = "Test Mofardini API",
            Endpoint = "http://url-test.com",
            HttpMethod = HttpMethod.Post,
            CreatedBy = "mofardlu",
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
            CreatedBy = inputDTO.CreatedBy,
            UpdatedBy = null,
            CronExpression = CronHelper.ConvertFrom(inputDTO.Periodicity, inputDTO.DaysOfWeek),
            LastStatus = null,
            LastRun = null,
            AuthenticationType = (int) inputDTO.AuthenticationType
        };

        var service = new HealthCheckService(new MonitoredItemService());
        
        var result = service.CreateMonitoredApi(inputDTO);

        result.Should().Be(expectedResult);
    }
}