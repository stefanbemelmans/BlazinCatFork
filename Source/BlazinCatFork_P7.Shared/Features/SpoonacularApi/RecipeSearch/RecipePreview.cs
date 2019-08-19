using System;
using System.Collections.Generic;
using System.Text;

namespace BlazinCatFork_P7.Shared.Features.SpoonacularApi.RecipeSearch
{
  public class RecipePreview
  {
    public RecipePreview(){} 
    public int Id { get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }
    public int UsedIngredientCount { get; set; }
    public int MissedIngredientCount { get; set; }
    public int Likes { get; set; }
  }
}
