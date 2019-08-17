using BlazinCatFork.Client.Features.CatPic;
using BlazinCatFork.Shared.Features.CatPic;
using BlazinCatfork_P7.Client.Features.Base;
using BlazorState;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace BlazinCatfork_P7.Client.Features.CatPic
{
  internal partial class CatPicState 
  {
    public class GetCatPicHandler : BaseHandler<GetCatPicAction, CatPicState>
    {
      public GetCatPicHandler(IStore aStore, HttpClient aHttpClient) : base(aStore)
      {
        HttpClient = aHttpClient;
      }
      private HttpClient HttpClient { get; }
      private CatPicState CatPicState => Store.GetState<CatPicState>();
      public override async Task<CatPicState> Handle
      (
        GetCatPicAction aGetCatPicAction,
        CancellationToken aCancellationToken
      )
      {
        SearchResponse CatPicList = await HttpClient.GetJsonAsync<SearchResponse>(SearchRequest.Route);

        CatPicState. = CatPicList.Images[0].Url;

        return CatPicState;
      }
    }
  }
}
