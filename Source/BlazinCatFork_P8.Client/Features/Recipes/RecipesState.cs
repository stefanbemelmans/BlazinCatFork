namespace BlazinCatFork_P8.Client.Features.Recipes
{
  using BlazinCatFork_P8.Shared.Features.SpoonacularApi;
  using BlazorState;
  using System.Collections.Generic;

  public class RecipesState : State<RecipesState>
    {
        List<RecipeSearchResult> RecipeSearchResults { get; set; }

    protected override void Initialize() => throw new System.NotImplementedException();
  }
}
