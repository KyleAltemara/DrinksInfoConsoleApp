using DrinksInfoConsoleApp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DrinksInfoConsoleApp;

public static class Startup
{
    /// <summary>
    /// Configures the services that the application will use.
    /// </summary>
    /// <returns> An <see cref="IServiceProvider"/> containing the configured services. </returns>
    public static IServiceProvider ConfigureServices()
    {
        // Create a service collection and configure our services
        var services = new ServiceCollection()
            .AddSingleton<DrinkService>()
            .AddSingleton<Menu>();
        // Build the service provider
        return services.BuildServiceProvider();
    }
}
