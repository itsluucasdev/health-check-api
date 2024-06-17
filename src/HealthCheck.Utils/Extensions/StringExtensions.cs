namespace HealthCheck.Utils.Extensions;

public static class StringExtensions
{
    public static string JoinThis(this IEnumerable<string> input, char separator = ',')
        => string.Join(separator, input);
}