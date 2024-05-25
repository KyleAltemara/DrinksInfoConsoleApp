using DrinksInfoConsoleApp.DTOs;

namespace DrinksInfoConsoleApp.Models;

/// <summary>
/// Represents a drink category.
/// </summary>
/// <param name="category"> The <see cref="DrinkCategoryJSON"/> that will be used to create the <see cref="DrinkCategory"/>. </param>
public class DrinkCategory(DrinkCategoryJSON category)
{
    public string Category { get; set; } = category.strCategory;
}
