namespace DrinksInfoConsoleApp.DTOs;

/// <summary>
/// Represents a drink JSON object from the API, received when requesting drinks by category.
/// </summary>
public class DrinkJSON
{
#pragma warning disable IDE1006 // Naming Styles
    public required string idDrink { get; set; }
    public required string strDrink { get; set; }
#pragma warning restore IDE1006 // Naming Styles
}
