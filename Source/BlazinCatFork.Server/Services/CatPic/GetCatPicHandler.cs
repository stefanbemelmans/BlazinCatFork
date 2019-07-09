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
      string catpicurl = await CatPicHttpClient.GetStringAsync(CatPicHttpClient.MedCatUrl);

      List<object> catrep = JsonConvert.DeserializeObject<List<object>>(catpicurl);
      string WegotThis = catrep[0].ToString();
      GetCatPicResponse acatpicurl = JsonConvert.DeserializeObject<GetCatPicResponse>(WegotThis);

      return acatpicurl;
    }
  }
}
