namespace BlazinCatFork_P8.Client.Integration.Tests.Features.Recipes
{
  using AnyClone;
  using BlazinCatFork_P8.Client.Features.Recipes;
  using BlazinCatFork_P8.Client.Integration.Tests.Infrastructure;
  using BlazorState;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using MediatR;
  using BlazinCatFork_P8.Shared.Features.SpoonacularApi;
  using System.Threading.Tasks;
  using BlazinCatFork_P8.Client.Features.Recipes.Actions;

  internal class ClientCatPicSearchTests
  {
    RecipeState RecipeState { get; set; }
    private IMediator Mediator { get; set; }
    private IServiceProvider ServiceProvider { get; }
    private IStore Store { get; }

    public ClientCatPicSearchTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
      Store = ServiceProvider.GetService<IStore>();
      RecipeState = Store.GetState<RecipeState>();
    }

    public async Task ShouldRetrieveSearchResultsFromClient()
    {
      //Arrange
      var recipeSearchRequest = new RecipeSearchAction
      {
        Number= 15,
        Ingredients = "potato, chicken",
        Ranking = 1,
        IgnorePantry = true
      };

      //Act

      //Assert
      (await Mediator.Send(recipeSearchRequest)).RecipeSearchResults.Count.ShouldBe(15);
     
    }
  }
}