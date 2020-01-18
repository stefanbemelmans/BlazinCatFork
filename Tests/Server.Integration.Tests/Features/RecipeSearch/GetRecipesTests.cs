namespace BlazinCatfork.Server.Integration.Tests.Features.CatPic.SearchUrl
{
  using System;
  using System.Linq;
  using System.Threading.Tasks;
  using BlazinCatfork.Server.Integration.Tests.Infrastructure;
  using BlazinCatfork.Server.Services.SpoonacularApi;
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;

  class RecipeSearchTests
  {

    public RecipeSearchTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
    }

    private IServiceProvider ServiceProvider { get; }
    private IMediator Mediator { get; }

    public async Task ShouldGetCorrectNumberOfRecipes()
    {
      // Arrange
      string IngredientString = "beef, figs";

      var aRecipeSearchRequest = new RecipeSearchRequest
      {
        Number = 10,
        Ranking = 1,
        IgnorePantry = true,
        Ingredients = IngredientString

      };

      // Act
      RecipeSearchResponse recipeSearchResponse =
        await Mediator.Send(aRecipeSearchRequest);

      Console.WriteLine(recipeSearchResponse);
      //Assert
      recipeSearchResponse.RecipeSearchResults.Count.ShouldBe(10);

    }
  }
}
