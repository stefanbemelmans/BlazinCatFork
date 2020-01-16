namespace BlazinCatfork.Server.Services.CatPic
{
  using MediatR;
  using Microsoft.AspNetCore.Components;
  using System.Collections.Generic;
  using System.Threading.Tasks;
  using System.Threading;
  using Api.Features.CatPic;
  public class SearchHandler : IRequestHandler<SearchRequest, SearchResponse>
  {
    public TheCatApiHttpClient TheCatApiHttpClient { get; set; }

    public SearchHandler(TheCatApiHttpClient aTheCatApiHttpClient)
    {
      TheCatApiHttpClient = aTheCatApiHttpClient;
    }

    public async Task<SearchResponse> Handle(SearchRequest aSearchRequest, CancellationToken aCancellationToken)
    {
       aSearchRequest = new SearchRequest();

      List<Image> images = await TheCatApiHttpClient.GetJsonAsync<List<Image>>(aSearchRequest.SearchUrl);

      return new SearchResponse { Images = images };
    }
  }
}
