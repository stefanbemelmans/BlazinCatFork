namespace BlazinCatFork_P7.Server.Integration.Tests.Features.RecipeSearch

{
  using BlazinCatFork_P7.Server.Integration.Tests;
  using BlazinCatFork_P7.Server.Services.SpoonacularApi;
  using BlazinCatFork_P7.Shared.Features.SpoonacularApi.RecipeSearchTypes;
  using MediatR;
  using Microsoft.AspNetCore.Components;
  using Microsoft.AspNetCore.WebUtilities;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using System.Collections.Generic;
  using System.Net.Http;
  using System.Threading.Tasks;

  public class RecipeResponse
  {
    public List<RecipePreview> SearchResults { get; set; }
  }

  internal class RecipeSearchTests
  {
    private SpoonacularApiHttpClient SpoonHttpClient { get; }
    //private HttpClient HttpClient { get; }
    //private IMediator Mediator { get; }
    private IServiceProvider ServiceProvider { get; }
    

    public RecipeSearchTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      //Mediator = ServiceProvider.GetService<IMediator>();
      SpoonHttpClient = ServiceProvider.GetService<SpoonacularApiHttpClient>();
      //HttpClient = ServiceProvider.GetService<HttpClient>();
      
    }

    public async Task ShouldGetRecipeResponseWithAddedValues()
    {
      //const string IngredientSearchBaseUrl = "https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/findByIngredients";
      // Arrange
      //const string IngredientSearchUrl = RecipeSearchRequest.QueryStringBuilder();

      //string ingredientsToSearchFor = QueryHelpers.AddQueryString( RecipeSearchRequest.QueryStringBuilder());
      // Act
      List<RecipePreview> response = await SpoonHttpClient.GetJsonAsync<List<RecipePreview>>(RecipeSearchRequest.QueryStringBuilder());

      //Assert
      response.ShouldNotBeNull();
      response.ShouldBeOfType<List<RecipePreview>>();
    }

    //public async Task ShouldGetRecipeResponseWithPrebuiltUri()
    //{
    //  // Arrange
    //  const string IngredientSearchUrl = "https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/findByIngredients?number=5&ranking=1&ignorePantry=false&ingredients=onions%2C%20chicken";

    //  // Act
    //  List<RecipePreview> response = await HttpClient.GetJsonAsync<List<RecipePreview>>(IngredientSearchUrl);

    //  //Assert
    //  response.ShouldNotBeNull();
    //  response.ShouldBeOfType<List<RecipePreview>>();
    //}
        
  }
}