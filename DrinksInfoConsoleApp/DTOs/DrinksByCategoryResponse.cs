namespace DrinksInfoConsoleApp.DTOs;

/// <summary>
/// The response from the API when requesting drinks by category.
/// </summary>
public class DrinksByCategoryResponse
{
#pragma warning disable IDE1006 // Naming Styles
    public required List<DrinkJSON> drinks { get; set; }
#pragma warning restore IDE1006 // Naming Styles
}
