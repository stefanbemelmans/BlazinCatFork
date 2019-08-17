﻿namespace BlazinCatFork.Server.Integration.Tests.Features.CatPic.SearchUrl
{
  using System;
  using System.Linq;
  using System.Threading.Tasks;
  using BlazinCatFork.Server.Services.CatPic;
  using BlazinCatfork_P7.Server.Integration.Tests;
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;

  class SearchTests
  {

    public SearchTests(TestFixture aTestFixture)
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