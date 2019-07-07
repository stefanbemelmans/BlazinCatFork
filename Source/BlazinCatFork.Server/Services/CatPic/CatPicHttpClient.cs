﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazinCatFork.Server.Services.CatPic
{
  public class CatPicHttpClient
  {
    public CatPicHttpClient(IHttpClientFactory aHttpClient)
    {
      CatClient = aHttpClient.CreateClient();
      CatClient.BaseAddress = new Uri(MedCatUrl);
      CatClient.DefaultRequestHeaders.Add("x-api", CatApiKey);
    }
    public HttpClient CatClient { get; set; }

    public static string  MedCatUrl = "https://api.thecatapi.com/v1/images/search?size=med";
    private const string CatApiKey = "23e061a5-c2d3-480e-8105-2fd0fb96a6aa";

    //private static IHttpClientFactory CatClientFactory;

    //public static HttpClient CatClient = CatClientFactory.CreateClient();
    //public static HttpRequestMessage CatPicRequestMessage = new HttpRequestMessage(HttpMethod.Get, MedCatUrl);

      

    
  }
}
