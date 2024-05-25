using Spectre.Console;

namespace DrinksInfoConsoleApp.Services;

/// <summary>
/// Represents the menu that the user will interact with.
/// </summary>
public class Menu
{
    /// <summary>
    /// The <see cref="DrinkService"/> that will be used to interact with the API.
    /// </summary>
    private readonly DrinkService _drinkService;

    public Menu()
    {
        _drinkService = new DrinkService();
    }

    /// <summary>
    /// Shows the menu to the user.
    /// The user can choose a drink category and then a drink from that category.
    /// </summary>
    /// <returns> A <see cref="Task"/> representing the asynchronous operation. </returns>
    public async Task ShowMenu()
    {
        while (true)
        {
            AnsiConsole.Clear();
            var categories = (await _drinkService.GetDrinkCategories()).Select(c => c.Category).ToList();
            categories.Add("Exit");
            var selectedCategory = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Please choose a drink category")
                    .PageSize(25)
                    .AddChoices(categories));
            if (selectedCategory == "Exit")
            {
                break;
            }

            var drinks = (await _drinkService.GetDrinksByCategory(selectedCategory)).ToDictionary(d => d.Name, d => d);
            drinks.Add("Return", null);
            drinks.Add("Exit", null);
            var selectedDrink = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Please choose a drink")
                    .PageSize(25)
                    .AddChoices(drinks.Keys));
            if (selectedDrink == "Return")
            {
                continue;
            }

            if (selectedDrink == "Exit")
            {
                break;
            }

            var drink = drinks[selectedDrink];
            var drinkDetails = await _drinkService.GetDrinkDetailsById(drink.Id);
            AnsiConsole.MarkupLine($"[bold]{drinkDetails.Name}[/]");
            AnsiConsole.MarkupLine($"[bold]Category:[/] {drinkDetails.Category}");
            AnsiConsole.MarkupLine($"[bold]Alcoholic:[/] {drinkDetails.Alcoholic}");
            AnsiConsole.MarkupLine($"[bold]Glass:[/]: {drinkDetails.Glass}");
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("[bold]Ingredients:[/]");
            for (var i = 0; i < drinkDetails.Ingredients.Count; i++)
            {
                AnsiConsole.Markup($"[bold]{drinkDetails.Ingredients[i]}[/]");
                if (drinkDetails.Measures[i] != null)
                {
                    AnsiConsole.Markup($": {drinkDetails.Measures[i]}");
                }

                AnsiConsole.WriteLine();
            }

            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine($"[bold]Instructions:[/] {drinkDetails.Instructions}");
            AnsiConsole.WriteLine();
            var continuePrompt = AnsiConsole.Confirm("Look up another drink?");
            if (!continuePrompt)
            {
                break;
            }
        }
    }
}
