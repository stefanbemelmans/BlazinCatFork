namespace BlazinCatFork.Server.Integration.Tests.Features.CatPic.GetCatPicUrl
{
  using System;
  using System.Threading.Tasks;
  using BlazinCatFork.Server.Services.CatPic;
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;

  class GetCatPicTests
  {

    public GetCatPicTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
    }

    private IServiceProvider ServiceProvider { get; }
    private IMediator Mediator { get; }

    public async Task ShouldGetACatPicUrl()
    {
      // Arrange
      var getCatPicRequest = new GetCatPicRequest();

      //Act
      GetCatPicResponse getCatPicResponse =
        await Mediator.Send(getCatPicRequest);

      //Assert
      getCatPicResponse.url.ShouldNotBeNull();

    }
  }
}
