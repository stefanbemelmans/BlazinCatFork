using BlazinCatFork_P8.Shared.Features.SpoonacularApi;
using MediatR;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BlazinCatFork_P8.Server.Services.SpoonacularApi
{
  public class RecipeSearchHandler : IRequestHandler<RecipeSearchRequest, RecipeSearchResponse>
  {
    public SpoonacularApiHttpClient SpoonApi { get; }

    public RecipeSearchHandler(SpoonacularApiHttpClient aSpoonacularApi)
    {
      SpoonApi = aSpoonacularApi;
    }

    public async Task<RecipeSearchResponse> Handle(RecipeSearchRequest aRequest, CancellationToken cancellationToken)
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