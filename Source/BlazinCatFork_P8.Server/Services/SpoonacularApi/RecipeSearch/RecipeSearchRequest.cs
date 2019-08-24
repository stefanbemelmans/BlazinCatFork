namespace BlazinCatFork_P8.Server.Services.SpoonacularApi
{
  using MediatR;
  using Microsoft.AspNetCore.WebUtilities;

  public class RecipeSearchRequest : IRequest<RecipeSearchResponse>
  {
    public int Number { get; set; } = 5; // Of Recipes
    public int Ranking { get; set; } = 1; // Whether to maximize used ingredients (1) or minimize missing ingredients (2) first.
    public bool IgnorePantry { get; set; } = true;
    public string Ingredients { get; set; } = "beef, figs";
  }
}