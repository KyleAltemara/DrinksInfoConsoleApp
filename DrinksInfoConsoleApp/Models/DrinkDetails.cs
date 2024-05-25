using DrinksInfoConsoleApp.DTOs;

namespace DrinksInfoConsoleApp.Models;

/// <summary>
/// Containsthe details to make the drink.
/// </summary>
public class DrinkDetails
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<string> Tags { get; set; }
    public string Category { get; set; }
    public string Alcoholic { get; set; }
    public string Glass { get; set; }
    public string Instructions { get; set; }
    public List<string> Ingredients { get; set; }
    public List<string> Measures { get; set; }

    public DrinkDetails(DrinkDetailsJSON drink)
    {
        Id = int.Parse(drink.idDrink);
        Name = drink.strDrink;
        Tags = drink.strTags;
        Category = drink.strCategory;
        Alcoholic = drink.strAlcoholic;
        Glass = drink.strGlass;
        Instructions = drink.strInstructions;
        Ingredients =
        [
            drink.strIngredient1,
            drink.strIngredient2,
            drink.strIngredient3,
            drink.strIngredient4,
            drink.strIngredient5,
            drink.strIngredient6,
            drink.strIngredient7,
            drink.strIngredient8,
            drink.strIngredient9,
            drink.strIngredient10,
            drink.strIngredient11,
            drink.strIngredient12,
            drink.strIngredient13,
            drink.strIngredient14,
            drink.strIngredient15
        ];
        Ingredients.RemoveAll(string.IsNullOrWhiteSpace);
        Measures =
        [
            drink.strMeasure1,
            drink.strMeasure2,
            drink.strMeasure3,
            drink.strMeasure4,
            drink.strMeasure5,
            drink.strMeasure6,
            drink.strMeasure7,
            drink.strMeasure8,
            drink.strMeasure9,
            drink.strMeasure10,
            drink.strMeasure11,
            drink.strMeasure12,
            drink.strMeasure13,
            drink.strMeasure14,
            drink.strMeasure15
        ];
        Measures = Measures[..Ingredients.Count];
    }
}
