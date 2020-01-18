﻿namespace BlazinCatfork.Server.Integration.Tests.Features.CatPic.SearchUrl
{
  using System;
  using System.Linq;
  using System.Threading.Tasks;
  using BlazinCatfork.Server.Integration.Tests.Infrastructure;
  using BlazinCatfork.Server.Services.CatPic;
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
      var SearchRequest = new SearchRequest();

      // Act
      SearchResponse response =
        await Mediator.Send(SearchRequest);

      Console.WriteLine(response);
      //Assert
      response.Images.First().Url.ShouldNotBeNull();

    }
  }
}