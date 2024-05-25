namespace DrinksInfoConsoleApp.DTOs;

/// <summary>
/// Represents a drink category JSON object from the API, received when requesting all drink categories.
/// </summary>
public class DrinkCategoryJSON
{
#pragma warning disable IDE1006 // Naming Styles
    public required string strCategory { get; set; }
#pragma warning restore IDE1006 // Naming Styles
}
