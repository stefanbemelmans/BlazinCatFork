namespace BlazinCatfork.Api.Features.SpoonacularApi
{
  using MediatR;
  using Microsoft.AspNetCore.WebUtilities;
  using System.Collections.Generic;
  public class SharedRecipeSearchRequest : IRequest<SharedRecipeSearchResponse>
  {

    public const string Route = "api/recipeSearch";

    public const string IngredientSearchEndpoint = "findByIngredients";

    public bool IgnorePantry { get; set; }
    public string Ingredients { get; set; }
    public int Number { get; set; }
    public int Ranking { get; set; }

    //public int number { get; set; } = 5; // Of Recipes
    //public int ranking { get; set; } = 1; // Whether to maximize used ingredients (1) or minimize missing ingredients (2) first.
    //public bool ignorePantry { get; set; } = true;
    //public string ingredients { get; set; } = "chicken, onion";

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

      /*I'm going to have this return a string, and turn it into a URI by in the Handler*/
     string ingredientSearchString = QueryHelpers.AddQueryString(IngredientSearchEndpoint, searchParams);
      return ingredientSearchString;
    }
  }
}