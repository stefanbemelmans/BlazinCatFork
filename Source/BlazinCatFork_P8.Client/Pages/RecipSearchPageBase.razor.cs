namespace BlazinCatFork_P8.Client.Pages
{
  using BlazinCatFork_P8.Client.Features.Base.Components;
  using BlazinCatFork_P8.Client.Features.Recipes;
  using System.Collections.Generic;

  public class RecipeSearchPageBase : BaseComponent
  {
    public const string Route = "/recipeSearch";

    List<RecipeSearchResult> RecipeSearchResults => RecipeState.RecipeSearchResults;
  }
}
