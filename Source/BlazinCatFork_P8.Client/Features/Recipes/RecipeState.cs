namespace BlazinCatFork_P8.Client.Features.Recipes
{
  using BlazorState;
  using System.Collections.Generic;

  internal partial class RecipeState : State<RecipeState>
  {
    public List<RecipeSearchResult> RecipeSearchResults { get; set; }

    protected override void Initialize() => RecipeSearchResults = new List<RecipeSearchResult>();
  }
}