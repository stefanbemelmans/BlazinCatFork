namespace BlazinCatFork_P8.Client.Features.Recipes.Actions
{
  using BlazinCatFork_P8.Shared.Features.Base;
  using BlazinCatFork_P8.Shared.Features.SpoonacularApi;
  using MediatR;

  public class RecipeSearchAction : BaseRequest, IRequest<RecipeState>
  {

    public SharedRecipeSearchRequest SearchRequest { get; set; }
    public RecipeSearchAction()
    {
      SearchRequest = new SharedRecipeSearchRequest();
    }
    //public bool ignorePantry { get; set; } = true;
    //public string ingredients { get; set; } = "chicken, onion";
    //public int number { get; set; } = 5; // Of Recipes
    //public int ranking { get; set; } = 1; // Whether to maximize used ingredients (1) or minimize missing ingredients (2) first.
  }
}