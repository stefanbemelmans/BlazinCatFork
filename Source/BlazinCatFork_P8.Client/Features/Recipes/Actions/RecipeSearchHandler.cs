using BlazinCatFork_P8.Client.Features.Base;
using BlazorState;
using System.Net.Http;

namespace BlazinCatFork_P8.Client.Features.Recipes.Actions
{
  internal partial class RecipeState
  {
    public class RecipeSearchHandler : BaseHandler<RecipeSearchAction, RecipeState>
    {
      private HttpClient HttpClient { get; }

      public RecipeSearchHandler(IStore aStore, HttpClient aHttpClient) : base(aStore)
      {
        HttpClient = aHttpClient;
      }


    }
  }
}