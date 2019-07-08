using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Threading;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BlazinCatFork.Server.Services.CatPic
{
  public class GetCatPicHandler : IRequestHandler<GetCatPicRequest, GetCatPicResponse>
  {

    public GetCatPicHandler(CatPicHttpClient aCatPicHttpClient)
    {
      CatPicHttpClient = aCatPicHttpClient; 
    }
    public CatPicHttpClient CatPicHttpClient = new CatPicHttpClient();

    public async Task<GetCatPicResponse> Handle(GetCatPicRequest aGetCatPicRequest, CancellationToken aCancellationToken)
    {
      GetCatPicResponse catpicurl = await CatPicHttpClient.GetJsonAsync<GetCatPicResponse>(CatPicHttpClient.MedCatUrl);
      //Console.WriteLine(catpicurl);
      GetCatPicResponse acatpicurl = JsonConvert.DeserializeObject<GetCatPicResponse>(catpicurl.ToString());
      return acatpicurl;
    }
  }
}
