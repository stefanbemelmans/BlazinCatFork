namespace BlazinCatFork_P7.Client.Integration.Tests.Features.CatPic
{
  using BlazinCatFork_P7.Client.Integration.Tests.Infrastructure;
  using BlazinCatFork_P7.Shared.Features.CatPic;
  using BlazorState;
  using Microsoft.AspNetCore.Components;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using System.Net.Http;
  using System.Threading.Tasks;

  internal class GetCatPicTests
  {
    private HttpClient HttpClient { get; }

    public GetCatPicTests(TestFixture aTestFixture)
    {
      IServiceProvider serviceProvider = aTestFixture.ServiceProvider;
      IStore store = serviceProvider.GetService<IStore>();
      HttpClient = serviceProvider.GetService<HttpClient>();
    }

    public async Task ShouldGetUrl()
    {
      SharedSearchResponse SharedResponse = await HttpClient.GetJsonAsync<SharedSearchResponse>(SharedSearchRequest.Route);
      SharedResponse.Images[0].Url.ShouldBeOfType<string>();
    }
  }
}