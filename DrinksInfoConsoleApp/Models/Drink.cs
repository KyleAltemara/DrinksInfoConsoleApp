using DrinksInfoConsoleApp.DTOs;

namespace DrinksInfoConsoleApp.Models;

/// <summary>
/// Represents a drink.
/// </summary>
/// <param name="drink"> The <see cref="DrinkJSON"/> that will be used to create the <see cref="Drink"/>. </param>
public class Drink(DrinkJSON drink)
{
    public int Id { get; set; } = int.Parse(drink.idDrink);
    public string Name { get; set; } = drink.strDrink;
}
