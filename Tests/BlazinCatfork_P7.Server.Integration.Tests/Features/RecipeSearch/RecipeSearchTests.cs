namespace BlazinCatFork_P7.Server.Integration.Tests.Features.RecipeSearch

{
  using BlazinCatFork_P7.Server.Integration.Tests;
  using BlazinCatFork_P7.Server.Services.SpoonacularApi;
  using BlazinCatFork_P7.Shared.Features.SpoonacularApi;
  using Microsoft.AspNetCore.Components;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using System.Collections.Generic;
  using System.Threading.Tasks;

  internal class SpoonApiRecipeSearchTests
  {
    private SpoonacularApiHttpClient SpoonHttpClient { get; }
    private IServiceProvider ServiceProvider { get; }

    public SpoonApiRecipeSearchTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      SpoonHttpClient = ServiceProvider.GetService<SpoonacularApiHttpClient>();
    }

      //public string Ingredients = QueryHelpers.AddQueryString(IngredientSearchUrl, queryParams);
    public async Task UseSpoonApi()
    {
      var recipeRequest = new RecipeSearchRequest()
      {
        ingredients = "chicken, onions"
      };

      string searchString = SharedRecipeSearchRequest.SearchUrlBuilder(recipeRequest.number, recipeRequest.ranking, recipeRequest.ignorePantry, recipeRequest.ingredients);
    //};
      List<RecipeSearchResult> response = await SpoonHttpClient.GetJsonAsync<List<RecipeSearchResult>>(searchString);

      response.Count.ShouldBe(5);

    }

  }


  
}

    
    
     




 