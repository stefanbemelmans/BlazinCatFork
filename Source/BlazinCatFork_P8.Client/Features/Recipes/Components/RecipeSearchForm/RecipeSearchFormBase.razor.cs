namespace BlazinCatFork_P8.Client.Features.Recipes.Components
{
  using BlazinCatFork_P8.Client.Features.Base.Components;
  using BlazinCatFork_P8.Shared.Features.SpoonacularApi;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Threading.Tasks;

  public class RecipeSearchFormBase : BaseComponent
  {
    public SharedRecipeSearchRequest RecipeSearchFormInputs { get; set; } = new SharedRecipeSearchRequest()
    {
      ingredients = "chicken, onions"
    };

    public static string CleanString(string aIngredientString)
    {
      string[] ingredientsSplit = aIngredientString.Split(',');
      var cleanedIngredients = new List<string>();
      foreach (string str in ingredientsSplit)
      {
        Console.WriteLine($"String in array: {str}");

        string trimmedString = str.Trim();
        if (!string.IsNullOrWhiteSpace(trimmedString) && trimmedString.All(char.IsLetter))
        {
          cleanedIngredients.Add(trimmedString);
        }
      };
      string cleanedStringList = string.Join(",", cleanedIngredients);
      Console.WriteLine($"Cleaned Ingredient string List, allegedly, {cleanedStringList} ");
      return cleanedStringList;
    }

    public async Task SumbitValidForm()
    {
      Console.WriteLine("Form Submitted Successfully!");
      Console.WriteLine($"{RecipeSearchFormInputs.ignorePantry}");
      Console.WriteLine($"{RecipeSearchFormInputs.ranking}");
      Console.WriteLine($"{RecipeSearchFormInputs.number}");
      Console.WriteLine($"{RecipeSearchFormInputs.ingredients}");

      string cleanedString = CleanString(RecipeSearchFormInputs.ingredients);

      _ = await Mediator.Send(new SharedRecipeSearchRequest()
      {
        number = RecipeSearchFormInputs.number,
        ranking = RecipeSearchFormInputs.ranking,
        ignorePantry = RecipeSearchFormInputs.ignorePantry,
        ingredients = cleanedString
      }
      );
    }
  }
}