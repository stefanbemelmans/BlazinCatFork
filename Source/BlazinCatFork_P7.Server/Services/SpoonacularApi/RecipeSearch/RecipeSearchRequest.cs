namespace BlazinCatFork_P7.Server.Services.SpoonacularApi
{
  using MediatR;
  using Microsoft.AspNetCore.WebUtilities;

  public class RecipeSearchRequest : IRequest<RecipeSearchResponse>
  {
    public int number { get; set; } = 5; // Of Recipes
    public int ranking { get; set; } = 1; // Whether to maximize used ingredients (1) or minimize missing ingredients (2) first.
    public bool ignorePantry { get; set; } = true;
    public string ingredients { get; set; }
  }
}