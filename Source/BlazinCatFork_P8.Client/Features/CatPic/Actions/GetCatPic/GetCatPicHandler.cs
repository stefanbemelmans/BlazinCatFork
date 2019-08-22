namespace BlazinCatFork_P8.Client.Features.CatPic
{
  using BlazinCatFork_P8.Client.Features.Base;
  using BlazinCatFork_P8.Shared.Features.CatPic;
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
        SharedSearchResponse CatPicList = await HttpClient.GetJsonAsync<SharedSearchResponse>(SharedSearchRequest.Route);
        string url = CatPicList.Images[0].Url;

        CatPicState.CatPicUrl = url;
        return CatPicState;
        
      }
    }
  }
}
