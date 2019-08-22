namespace BlazinCatFork_P8.Server.Services.SpoonacularApi
{
  using System;
  // https://rapidapi.com/spoonacular/api/recipe-food-nutrition/endpoints
  using System.Net.Http;
  public class SpoonacularApiHttpClient : HttpClient
  {
    const string SpoonacularBaseUrl = "https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/";
  
    const string SpoonRecipeSearchBase = "https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/findByIngredients?number=5&ranking=1&ignorePantry=false&";
    const string ApiKey = "621eab8993mshf9832d7bd9b883dp153b8bjsn92fda26a6103";
    public SpoonacularApiHttpClient()
    {
      BaseAddress = new System.Uri(SpoonacularBaseUrl);
      DefaultRequestHeaders.Add("x-rapidapi-host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
      DefaultRequestHeaders.Add("x-rapidapi-key", ApiKey);
      

    }

    
  }
}
