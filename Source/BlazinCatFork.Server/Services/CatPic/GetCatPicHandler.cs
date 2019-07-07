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
   
    //public CatPicHttpClient CatClient = new CatPicHttpClient(IHttpClientFactory aHttpClientFactory);

    public async Task<GetCatPicResponse> Handle(GetCatPicRequest aGetCatPicRequest, CancellationToken aCancellationToken)
    {
      GetCatPicResponse response = await CatPicHttpClient.CatClient.GetJsonAsync<GetCatPicResponse>(CatPicHttpClient.MedCatUrl);
      return response;
    }
  }
}
