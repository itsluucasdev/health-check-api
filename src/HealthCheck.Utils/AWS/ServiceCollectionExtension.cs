using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HealthCheck.Utils.AWS;

public static class ServiceCollectionExtension
{
    public static Tuple<IServiceCollection, IConfiguration> CreateConfig(this IServiceCollection sc)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
#if DEBUG
            .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true)
#elif RELEASE
            .AddJsonFile($"appsettings.json", optional: true, reloadOnChange: true)
#endif
            .Build();

        return new Tuple<IServiceCollection, IConfiguration>(sc, configuration);
    }
}