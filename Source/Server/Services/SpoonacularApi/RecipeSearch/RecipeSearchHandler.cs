namespace BlazinCatfork.Server.Services.SpoonacularApi
{
  using BlazinCatfork.Api.Features.SpoonacularApi;
  using MediatR;
  using Microsoft.AspNetCore.Components;
  using System.Collections.Generic;
  using System.Threading;
  using System.Threading.Tasks;

  public class RecipeSearchHandler : IRequestHandler<RecipeSearchRequest, RecipeSearchResponse>
  {
    public SpoonacularApiHttpClient SpoonApi { get; }

    public RecipeSearchHandler(SpoonacularApiHttpClient aSpoonacularApi)
    {
      SpoonApi = aSpoonacularApi;
    }

    public async Task<RecipeSearchResponse> Handle(RecipeSearchRequest aRequest, CancellationToken aCancellationToken)
    {
      string searchString = SharedRecipeSearchRequest.SearchUrlBuilder(aRequest.Number, aRequest.Ranking, aRequest.IgnorePantry, aRequest.Ingredients);

      List<RecipeSearchResult> recSearchResponse = await SpoonApi.GetJsonAsync<List<RecipeSearchResult>>(searchString);

      return new RecipeSearchResponse()
      {
        RecipeSearchResults = recSearchResponse
      };
    }
  }
}