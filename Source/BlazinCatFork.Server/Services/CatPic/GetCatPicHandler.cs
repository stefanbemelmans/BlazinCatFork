using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Threading;
using System.Net.Http;

namespace BlazinCatFork.Server.Services.CatPic
{
  public class GetCatPicHandler : IRequestHandler<GetCatPicRequest, GetCatPicResponse>
  {

    public GetCatPicHandler(CatPicHttpClient aCatPicHttpClient)
    {
      CatClient = aCatPicHttpClient;
    }
    public CatPicHttpClient CatClient { get; }

    public async Task<GetCatPicResponse> Handle(GetCatPicRequest aGetCatPicRequest, CancellationToken aCancellationToken)
    {
      GetCatPicResponse response = await CatClient.CatClient.GetJsonAsync<GetCatPicResponse>("");
      return response;
    }
  }
}
