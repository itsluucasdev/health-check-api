using HealthCheck.Utils.Extensions;

namespace HealthCheck.Utils.CronExpression;

public static class CronHelper
{
    public static string ConvertFrom(int periodicity, int[] daysOfWeek) 
    {
        var interval = periodicity / 60 ;

        var days = daysOfWeek.Select(d => d.ToString()).JoinThis();
        
        return $"cron (0/{interval} * * {days} ? *)";
    }
}