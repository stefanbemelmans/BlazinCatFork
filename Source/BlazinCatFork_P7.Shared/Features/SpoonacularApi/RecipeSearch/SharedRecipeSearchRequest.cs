namespace BlazinCatFork_P7.Shared.Features.SpoonacularApi
{
  using MediatR;
  using Microsoft.AspNetCore.WebUtilities;
  using System.Collections.Generic;
  public class SharedRecipeSearchRequest : IRequest<SharedRecipeSearchResponse>
  {
    public const string IngredientSearchEndpoint = "findByIngredients";
    public static int number { get; set; } = 5; // Of Recipes
    public static int ranking { get; set; } = 1; // Whether to maximize used ingredients (1) or minimize missing ingredients (2) first.
    public static bool ignorePantry { get; set; } = true;
    public static string ingredients { get; set; }

    //public bool limitLicense { get; set; } = false;
    public static string SearchUrlBuilder(int aNumOfRecipes, int aRecRanking, bool aPantIgnore, string aIngs)
    {
      var searchParams = new Dictionary<string, string>()
      {
        { "number", aNumOfRecipes.ToString() },
        { "ranking", aRecRanking.ToString() },
        { "ignorePantry", aPantIgnore.ToString() },
        { "ingredients", aIngs }
      };

      string ingredientSearchString = QueryHelpers.AddQueryString(IngredientSearchEndpoint, searchParams);
      return ingredientSearchString;
    }
  }
}