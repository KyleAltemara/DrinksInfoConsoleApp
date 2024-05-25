using DrinksInfoConsoleApp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DrinksInfoConsoleApp;

internal static class Program
{
    static void Main()
    {
        // Create a service collection and configure our services
        var serviceProvider = Startup.ConfigureServices();
        // Get an instance of our menu
        var menu = serviceProvider.GetRequiredService<Menu>();
        // Run the menu
        Task.Run(menu.ShowMenu).GetAwaiter().GetResult();
    }
}