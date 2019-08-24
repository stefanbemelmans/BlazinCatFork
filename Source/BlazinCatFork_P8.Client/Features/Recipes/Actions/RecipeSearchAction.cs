namespace BlazinCatFork_P8.Client.Features.Recipes.Actions
{
  using BlazinCatFork_P8.Shared.Features.Base;
  using BlazinCatFork_P8.Shared.Features.SpoonacularApi;
  using MediatR;

  public class RecipeSearchAction : BaseRequest, IRequest<RecipeState>
  {

    public bool IgnorePantry { get; set; } = true;
    public string Ingredients { get; set; } = "chicken, onion";
    public int Number { get; set; } = 5; // Of Recipes
    public int Ranking { get; set; } = 1; // Whether to maximize used ingredients (1) or minimize missing ingredients (2) first.
  }
}