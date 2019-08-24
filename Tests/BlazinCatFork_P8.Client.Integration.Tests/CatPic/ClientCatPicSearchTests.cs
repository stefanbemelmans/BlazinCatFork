namespace BlazinCatFork_P8.Client.Integration.Tests.Features.CatPic
{
  using BlazinCatFork_P8.Client.Features.CatPic;
  using BlazinCatFork_P8.Client.Integration.Tests.Infrastructure;
  using BlazorState;
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using System.Threading.Tasks;

  internal class ClientCatPicSearchTests
  {
    private CatPicState CatPicState { get; set; }
    private IMediator Mediator { get; set; }
    private IServiceProvider ServiceProvider { get; }
    private IStore Store { get; }

    public ClientCatPicSearchTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
      Store = ServiceProvider.GetService<IStore>();
      CatPicState = Store.GetState<CatPicState>();
    }

    public async Task ShouldRetrieveSearchResultsFromClient()
    {
      //Arrange
      var catPicSearchRequest = new GetCatPicAction();

      //Act

      //Assert
      CatPicState url = await Mediator.Send(catPicSearchRequest);
      url.CatPicUrl.ShouldNotBe(null);
    }
  }
}