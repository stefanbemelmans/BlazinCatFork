using System.Collections.Generic;

namespace BlazinCatFork_P8.Shared.Features.SpoonacularApi
{
  public class RecipeInfo
  {
    public int aggregateLikes { get; set; }
    public bool cheap { get; set; }
    public bool dairyFree { get; set; }
    public string gaps { get; set; }
    public bool glutenFree { get; set; }
    public int id { get; set; }
    public string image { get; set; }
    public string imageType { get; set; }
    public string instructions { get; set; }
    public bool ketogenic { get; set; }
    public bool lowFodmap { get; set; }
    public int readyInMinutes { get; set; }
    public int servings { get; set; }
    public string sourceName { get; set; }
    public string sourceUrl { get; set; }
    public string spoonacularSourceUrl { get; set; }
    public bool sustainable { get; set; }
    public string title { get; set; }
    public bool vegan { get; set; }
    public bool vegetarian { get; set; }
    public bool veryHealthy { get; set; }
    public bool veryPopular { get; set; }
    public int weightWatcherSmartPoints { get; set; }
    public bool whole30 { get; set; }
    public List<Ingredient> extendedIngredients { get; set; }
  }
}

public class Ingredient
{
  public string aisle { get; set; }
  public int amount { get; set; }
  public int id { get; set; }
  public string image { get; set; } // url
  public List<string> metaInformation { get; set; }
  public string name { get; set; }
  public string originalString { get; set; }
  public string unit { get; set; }
  public string unitLong { get; set; }
  public string unitShort { get; set; }
}

public class RecipeSearchResult
{
  public int id { get; set; }

  public string image { get; set; }

  //public List<Ingredient> missedIngredients { get; set; } = new List<Ingredient>();
  public int likes { get; set; }

  //public List<Ingredient> usedIngredients { get; set; }
  public int missedIngredientCount { get; set; }

  public string title { get; set; }

  public int usedIngredientCount { get; set; }

  public RecipeSearchResult() { }

  // url
}