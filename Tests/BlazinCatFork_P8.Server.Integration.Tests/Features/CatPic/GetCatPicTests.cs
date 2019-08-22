namespace BlazinCatFork_P8.Server.Integration.Tests.Features.CatPic.SearchUrl
{
  using BlazinCatFork_P8.Server.Integration.Tests.Infrastructure;
  using BlazinCatFork_P8.Server.Services.CatPic;
  using BlazinCatFork_P8.Shared.Features.CatPic;
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using System.Linq;
  using System.Threading.Tasks;

  internal class SearchTests
  {
    private IMediator Mediator { get; }

    private IServiceProvider ServiceProvider { get; }

    public SearchTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
    }

    public async Task ShouldGetServerFeaturesCatPicUrl()
    {
      // Arrange
      var SearchRequest = new SharedSearchRequest();

      // Act
      SharedSearchResponse response = await Mediator.Send(new SharedSearchRequest());

      Console.WriteLine(response);
      //Assert
      response.Images.First().Url.ShouldNotBeNull();
      response.Images.First().Url.ShouldBeOfType<string>();
    }

    public async Task ShouldGetServerServiceCatPicUrl()
    {
      // Arrange
      var SearchRequest = new SearchRequest();

      // Act
      SearchResponse response =
        await Mediator.Send(SearchRequest);

      Console.WriteLine(response);
      //Assert
      response.Images.First().Url.ShouldNotBeNull();
      response.Images.First().Url.ShouldBeOfType<string>();
    }
  }
}