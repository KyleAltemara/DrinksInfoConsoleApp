# DrinksInfoConsoleApp

<https://www.thecsharpacademy.com/project/15/drinks>
This is a console application that allows users to browse and get details about various drinks. The application uses an API from [TheCocktailDB](https://www.thecocktaildb.com/api.php) to fetch and display drink data. Users can select a drink category and then a drink from that category to view its details.

## Features

- API Interaction: The application interacts with TheCocktailDB API to fetch drink data. This is handled by the `DrinkService` class.
- Drink Categories: Users can view a list of drink categories. This is managed by the `GetDrinkCategories` method in the `DrinkService` class.
- Drinks by Category: Users can select a category and view a list of drinks in that category. This is managed by the `GetDrinksByCategory` method in the `DrinkService` class.
- Drink Details: Users can select a drink and view its details, including ingredients and instructions. This is managed by the `GetDrinkDetailsById` method in the `DrinkService` class.
- Menu Options: The application presents a menu to the user with options to select a drink category, select a drink, and exit the application. This is implemented using the `SelectionPrompt` class from the `Spectre.Console` library.
- Termination: The application continues to run until the user chooses the "Exit" option.

## Getting Started

To run the application, follow these steps:

1. Make sure you have the necessary dependencies installed, including Newtonsoft.Json and Spectre.Console.
2. Clone the repository to your local machine.
3. Open the solution in Visual Studio.
4. Build the solution to restore NuGet packages and compile the code.
5. Run the application.

## Dependencies

- Newtonsoft.Json: The application uses this package to deserialize JSON responses from the API.
- Spectre.Console: The application uses this package to create a user-friendly console interface.

## Usage

1. When the application starts, it will fetch a list of drink categories from the API.
2. The application will display a menu with options to select a drink category or exit the application.
3. Select a category by using the arrow keys and press Enter.
4. The application will then fetch and display a list of drinks in the selected category.
5. Select a drink by using the arrow keys and press Enter.
6. The application will fetch and display the details of the selected drink.
7. The application will continue to run until you choose the "Exit" option.

## License

This project is licensed under the [MIT License](LICENSE).

## Resources Used

- [The C# Academy](https://www.thecsharpacademy.com/)
- [TheCocktailDB API](https://www.thecocktaildb.com/api.php)
- GitHub Copilot to generate code snippets
