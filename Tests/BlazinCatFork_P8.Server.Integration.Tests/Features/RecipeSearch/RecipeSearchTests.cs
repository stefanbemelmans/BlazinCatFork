namespace BlazinCatFork_P8.Server.Integration.Tests.Features.RecipeSearch

{
  using MediatR;
  using BlazinCatFork_P8.Server.Services.SpoonacularApi;
  using BlazinCatFork_P8.Shared.Features.SpoonacularApi;
  using Microsoft.AspNetCore.Components;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using System.Collections.Generic;
  using System.Threading.Tasks;
  using BlazinCatFork_P8.Server.Integration.Tests.Infrastructure;

  internal class SpoonApiRecipeSearchTests
  {
    private SpoonacularApiHttpClient SpoonHttpClient { get; }
    private IMediator Mediator { get; }
    private IServiceProvider ServiceProvider { get; }

    public SpoonApiRecipeSearchTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      SpoonHttpClient = ServiceProvider.GetService<SpoonacularApiHttpClient>();
      Mediator = ServiceProvider.GetService<IMediator>();
    }

      //public string Ingredients = QueryHelpers.AddQueryString(IngredientsearchUrl, queryParams);
    public async Task UseSpoonApi()
    {
      var recipeRequest = new RecipeSearchRequest()
      {
        Ranking = 1,
        Ingredients = "chicken, onions",
        IgnorePantry = true,
        Number = 10
      };

      string searchString = SharedRecipeSearchRequest.SearchUrlBuilder(recipeRequest.Number, recipeRequest.Ranking, recipeRequest.IgnorePantry, recipeRequest.Ingredients);
    //};
      List<RecipeSearchResult> response = await SpoonHttpClient.GetJsonAsync<List<RecipeSearchResult>>(searchString);

      response.Count.ShouldBe(10);

    }

    public async Task UseServerRecipeSearchRequest()
    {
      var recipeRequest = new RecipeSearchRequest()
      {
        Ranking = 1,
        Ingredients = "chicken, onions",
        IgnorePantry = true,
        Number = 5
      };

     
      //};
      RecipeSearchResponse response = await Mediator.Send(recipeRequest);

      response.RecipeSearchResults.Count.ShouldBe(5);

    }

    public async Task UseSharedRecipeSearchRequest()
    {
      var sharedRecipeRequest = new SharedRecipeSearchRequest()
      {
        Ranking = 1,
        Ingredients = "chicken, onions",
        IgnorePantry = true,
        Number = 10
      };


      //};
      SharedRecipeSearchResponse response = await Mediator.Send(sharedRecipeRequest);

      response.RecipeSearchResults.Count.ShouldBe(10);

    }

  }


  
}

    
    
     




 