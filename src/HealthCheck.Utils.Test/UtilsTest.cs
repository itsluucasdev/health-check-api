using HealthCheck.Utils.CronExpression;

namespace HealthCheck.Utils.Test;

[TestClass]
public class UtilsTest
{

    [TestMethod]
    public void CronBuilder()
    {
        const int periodicityInput = 3600;
        int[] daysOfWeek = [2, 3, 4, 5, 6];

        var expectedResult = $"cron(0/59 * * 2,3,4,5,6 ? *)";

        var result = CronHelper.ConvertFrom(periodicityInput, daysOfWeek);

        Assert.AreEqual(expectedResult, result);
    }
}