namespace BlazinCatFork_P8.Client.Features.Recipes
{
  using BlazinCatFork_P8.Shared.Features.SpoonacularApi;
  using BlazorState;
  using System.Collections.Generic;

  internal partial class RecipeState : State<RecipeState>
  {
    public List<RecipeSearchResult> RecipeSearchResults { get; set; }

    protected override void Initialize() { }
  }
}
