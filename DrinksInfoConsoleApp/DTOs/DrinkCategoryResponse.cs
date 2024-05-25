namespace DrinksInfoConsoleApp.DTOs;

/// <summary>
/// The response from the API when requesting drink categories.
/// </summary>
public class DrinkCategoryResponse
{
#pragma warning disable IDE1006 // Naming Styles
    public required List<DrinkCategoryJSON> drinks { get; set; }
#pragma warning restore IDE1006 // Naming Styles
}
