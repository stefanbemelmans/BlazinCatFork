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
        SharedRecipeSearchResponse searchResults = await HttpClient.PutJsonAsync<SharedRecipeSearchResponse>(SharedRecipeSearchRequest.Route, new SharedRecipeSearchRequest()
        {
          number = aRecipeSearchAction.number,
          ranking = aRecipeSearchAction.ranking,
          ignorePantry = aRecipeSearchAction.ignorePantry,
          ingredients = aRecipeSearchAction.ingredients
        }
        );

        RecipeState.RecipeSearchResults = searchResults.RecipeSearchResults;

        return RecipeState;
      }
    }
  }
}