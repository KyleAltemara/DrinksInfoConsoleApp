using DrinksInfoConsoleApp.DTOs;
using DrinksInfoConsoleApp.Models;
using Newtonsoft.Json;
using Spectre.Console;

namespace DrinksInfoConsoleApp.Services;

public class DrinkService
{
    private readonly HttpClient _httpClient;

    public DrinkService()
    {
        _httpClient = new HttpClient { BaseAddress = new Uri("https://www.thecocktaildb.com/api/json/v1/1/") };
    }

    public async Task<List<DrinkCategory>> GetDrinkCategories()
    {
        var response = await _httpClient.GetStringAsync("list.php?c=list");
        var categoryResponse = JsonConvert.DeserializeObject<DrinkCategoryResponse>(response);
        var categories = categoryResponse.drinks.Select(d => new DrinkCategory(d)).ToList();
        return categories;
    }

    public async Task<List<Drink>> GetDrinksByCategory(string category)
    {
        var response = await _httpClient.GetStringAsync($"filter.php?c={category}");
        var drinksByCategoryResponse = JsonConvert.DeserializeObject<DrinksByCategoryResponse>(response);
        var drinks = drinksByCategoryResponse.drinks.Select(d => new Drink(d)).ToList();
        return drinks;
    }

    public async Task<DrinkDetails> GetDrinkDetailsById(int id)
    {
        var response = await _httpClient.GetStringAsync($"lookup.php?i={id}");
        var drinkDetailsByIdResponse = JsonConvert.DeserializeObject<DrinkDetailsByIdResponse>(response);
        var drinkDetails = new DrinkDetails(drinkDetailsByIdResponse.drinks.Single());
        return drinkDetails;
    }
}
