namespace BlazinCatFork_P8.Shared.Features.SpoonacularApi
{
  using System.Collections.Generic;

  public class RecipeSearchResult
  {
    public RecipeSearchResult()
    {
      //usedIngredients = new List<Ingredient>();
      //missedIngredients = new List<Ingredient>();
    }
    
    public int id { get; set; }
    public string title { get; set; }
    public string image { get; set; } // url
    public string imageType { get; set; }
    public int usedIngredientCount { get; set; }
    //public List<Ingredient> usedIngredients { get; set; }
    public int missedIngredientCount { get; set; }
    //public List<Ingredient> missedIngredients { get; set; } = new List<Ingredient>();
    public int likes { get; set; }
  }

  public class Ingredient
  {
    public int id { get; set; }
    public int amount { get; set; }
    public string unit { get; set; }
    public string unitShort { get; set; }
    public string unitLong { get; set; }
    public string aisle { get; set; }
    public string name { get; set; }
    public string original { get; set; }
    public string originalString { get; set; }
    public string originalName { get; set; }
    public List<string> metaInformation { get; set; }
    public string image { get; set; } // url
    
  }
}
