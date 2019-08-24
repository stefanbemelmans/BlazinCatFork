namespace BlazinCatFork_P8.Client.Features.Recipes.Components
{
  using BlazinCatFork_P8.Client.Features.Base.Components;
  using BlazinCatFork_P8.Client.Features.Recipes.Actions;
  using BlazinCatFork_P8.Shared.Features.SpoonacularApi;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Threading.Tasks;

  public class RecipeSearchFormBase : BaseComponent
  {
    private const string Value = "Form Submitted Successfully!";

    public RecipeSearchAction RecipeSearchFormInputs { get; set; } = new RecipeSearchAction();
  

    public static string CleanString(string aIngredientString)
    {
      if (aIngredientString is null)
      {
        throw new ArgumentNullException(nameof(aIngredientString));
      }

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
      Console.WriteLine($"{RecipeSearchFormInputs.IgnorePantry}");
      Console.WriteLine($"{RecipeSearchFormInputs.Ranking}");
      Console.WriteLine($"{RecipeSearchFormInputs.Number}");
      Console.WriteLine($"{RecipeSearchFormInputs.Ingredients}");

      string cleanedString = CleanString(RecipeSearchFormInputs.Ingredients);

      _ = await Mediator.Send(new RecipeSearchAction()
      {
        Number = RecipeSearchFormInputs.Number,
        Ranking = RecipeSearchFormInputs.Ranking,
        IgnorePantry = RecipeSearchFormInputs.IgnorePantry,
        Ingredients = cleanedString
      }
      ).ConfigureAwait(true);
    }
  }
}