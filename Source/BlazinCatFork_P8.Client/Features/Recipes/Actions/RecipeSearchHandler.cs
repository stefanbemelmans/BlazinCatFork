namespace BlazinCatFork_P8.Client.Features.Recipes
{
  using BlazinCatFork_P8.Client.Features.Base;
  using BlazinCatFork_P8.Client.Features.Recipes.Actions;
  using BlazinCatFork_P8.Shared.Features.SpoonacularApi;
  using BlazorState;
  using Microsoft.AspNetCore.Components;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;

  internal partial class RecipeState
  {
    public class RecipeSearchHandler : BaseHandler<RecipeSearchAction, RecipeState>
    {
      private HttpClient HttpClient { get; }

      public RecipeSearchHandler(IStore aStore, HttpClient aHttpClient) : base(aStore)
      {
        HttpClient = aHttpClient;
      }

      public override async Task<RecipeState> Handle(RecipeSearchAction aRecipeSearchAction, CancellationToken aCancellationToken)
      {
        var searchRequest = new RecipeSearchAction();

        searchRequest.Number = aRecipeSearchAction.Number;
        searchRequest.Ranking = aRecipeSearchAction.Ranking;
        searchRequest.IgnorePantry = aRecipeSearchAction.IgnorePantry;
        searchRequest.Ingredients = aRecipeSearchAction.Ingredients;

        SharedRecipeSearchResponse searchResults = await HttpClient.PostJsonAsync<SharedRecipeSearchResponse>(SharedRecipeSearchRequest.Route, searchRequest);

        RecipeState.RecipeSearchResults = searchResults.RecipeSearchResults;

        return RecipeState;
      }
    }
  }
}