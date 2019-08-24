namespace BlazinCatFork_P8.Client.Features.Recipes.Components.RecipeSearchResultComponent
{
  using BlazinCatFork_P8.Client.Features.Base.Components;
  using Microsoft.AspNetCore.Components;
  using System;
  using System.Threading.Tasks;

  public class RecipeSearchResultComponentBase : BaseComponent
  {
    [Parameter]
    public RecipeSearchResult RecipeSearchResult { get; set; }
    public void GetRecipeDetails()
    {
      // Call the GetRecipeDetails api endpoint

      Console.WriteLine($"Recipe ID: {RecipeSearchResult.id}");
    }
  }

}
