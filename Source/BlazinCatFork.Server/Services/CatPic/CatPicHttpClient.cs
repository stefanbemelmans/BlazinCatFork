using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazinCatFork.Server.Services.CatPic
{
  public class CatPicHttpClient
  {
    private static IHttpClientFactory CatClientFactory;

    public HttpClient CatClient = CatClientFactory.CreateClient();
    public string  MedCatUrl = "https://api.thecatapi.com/v1/images/search?size=med";
    private const string CatApiKey = "23e061a5-c2d3-480e-8105-2fd0fb96a6aa";

    public HttpRequestMessage CatPicRequestMessage = new HttpRequestMessage(HttpMethod.Get, MedCatUrl);

  }
}
