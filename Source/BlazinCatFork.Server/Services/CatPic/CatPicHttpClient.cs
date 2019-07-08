using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazinCatFork.Server.Services.CatPic
{
  public class CatPicHttpClient : HttpClient
  {
    public CatPicHttpClient()
    {
      //CatPicEndpoint = new System.Uri(MedCatUrl);
      DefaultRequestHeaders.Add("x-api", CatApiKey);
    }
    //public static HttpClient CatClient = new HttpClient();

    public static string  MedCatUrl = "https://api.thecatapi.com/v1/images/search?size=med";

    public const string CatApiKey = "23e061a5-c2d3-480e-8105-2fd0fb96a6aa";

    //public Uri CatPicEndpoint { get; }
    //public static HttpRequestMessage CatPicRequestMessage = new HttpRequestMessage(HttpMethod.Get, MedCatUrl);



  }
}
