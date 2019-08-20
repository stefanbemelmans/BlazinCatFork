namespace BlazinCatFork_P7.Server.Services.SpoonacularApi
{
  using MediatR;
  using Microsoft.AspNetCore.WebUtilities;

  public class RecipeSearchRequest : IRequest<RecipeSearchResponse>
  {
    public bool ignorePantry { get; set; } = true;
    public string ingredients { get; set; }
    public bool limitLicense { get; set; } = false;
    public int numberOfRecipes { get; set; } = 5;
    public int ranking { get; set; } = 1; // Whether to maximize used ingredients (1) or minimize missing ingredients (2) first.

    //public static string QueryStringBuilder()
    //{
    //  string ingredientsToSearchFor = QueryHelpers.AddQueryString(SpoonacularApiHttpClient.IngredientSearchUrl, "ingredients", "chicken, onions");
    //  return ingredientsToSearchFor;
    //}
  }
}