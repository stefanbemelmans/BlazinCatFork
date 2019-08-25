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
    private IMediator Mediator { get; set; }
    private IServiceProvider ServiceProvider { get; }
    private IStore Store { get; }

    public ClientCatPicSearchTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
      Store = ServiceProvider.GetService<IStore>();
    }

    public async Task ShouldRetrieveCatPicFromClient()
    {
      //Arrange
      var catPicSearchRequest = new GetCatPicAction();

      //Act

      //Assert
      CatPicState response =  await Mediator.Send(catPicSearchRequest); 
      response.CatPicUrl.ShouldNotBe(null);
      
    }
  }
}