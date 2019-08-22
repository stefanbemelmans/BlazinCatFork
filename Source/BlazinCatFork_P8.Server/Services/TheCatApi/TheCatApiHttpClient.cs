namespace BlazinCatFork_P8.Server.Services.CatPic
{
  using System.Net.Http;

  public class TheCatApiHttpClient : HttpClient
  {
    const string HostUrl = "https://api.thecatapi.com/v1/images/search?size=med"; // plans to separate size variable out
    const string ApiKey = "23e061a5-c2d3-480e-8105-2fd0fb96a6aa";
    public TheCatApiHttpClient()
    {
      BaseAddress = new System.Uri(HostUrl);
      DefaultRequestHeaders.Add("x-api-key", ApiKey);
    }
   
  }
}
