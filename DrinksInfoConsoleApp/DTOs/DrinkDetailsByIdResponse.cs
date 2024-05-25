namespace DrinksInfoConsoleApp.DTOs;

/// <summary>
/// The response from the API when requesting drink details by ID.
/// </summary>
public class DrinkDetailsByIdResponse
{
#pragma warning disable IDE1006 // Naming Styles
    public required List<DrinkDetailsJSON> drinks { get; set; }
#pragma warning restore IDE1006 // Naming Styles
}
