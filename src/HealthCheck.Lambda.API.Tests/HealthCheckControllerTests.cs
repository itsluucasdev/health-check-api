using System.Text.Json;
using Amazon.Lambda.TestUtilities;
using Amazon.Lambda.APIGatewayEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HealthCheck.Lambda.API.Tests;

[TestClass]
public class HealthCheckControllerTests
{
    [TestMethod]
    public async Task TestGet()
    {
        var lambdaFunction = new LambdaEntryPoint();

        var requestStr = File.ReadAllText("./SampleRequests/ValuesController-Get.json");
        var request = JsonSerializer.Deserialize<APIGatewayProxyRequest>(requestStr, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
        var context = new TestLambdaContext();
        var response = await lambdaFunction.FunctionHandlerAsync(request, context);

        Assert.Equals(200, response.StatusCode);
        Assert.Equals("[\"value1\",\"value2\"]", response.Body);
        Assert.IsTrue(response.MultiValueHeaders.ContainsKey("Content-Type"));
        Assert.Equals("application/json; charset=utf-8", response.MultiValueHeaders["Content-Type"][0]);
    }
}