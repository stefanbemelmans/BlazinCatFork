namespace BlazinCatFork_P7.Client.Features.CatPic
{
  using BlazinCatFork_P7.Client.Features.Base;
  using BlazinCatFork_P7.Shared.Features.CatPic;
  using BlazorState;
  using Microsoft.AspNetCore.Components;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;

  internal partial class CatPicState 
  {
    public class GetCatPicHandler : BaseHandler<GetCatPicAction, CatPicState>
    {
      public GetCatPicHandler(IStore aStore, HttpClient aHttpClient) : base(aStore)
      {
        HttpClient = aHttpClient;
      }
      private HttpClient HttpClient { get; }
      public override async Task<CatPicState> Handle
      (
        GetCatPicAction aGetCatPicAction,
        CancellationToken aCancellationToken
      )
      {
        SearchResponse CatPicList = await HttpClient.GetJsonAsync<SearchResponse>(SearchRequest.Route);
        string url = CatPicList.Images[0].Url;

        CatPicState.CatPicUrl = url;
        return CatPicState;
        
      }
    }
  }
}
