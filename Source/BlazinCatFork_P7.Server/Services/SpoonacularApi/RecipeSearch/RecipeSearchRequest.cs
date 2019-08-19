namespace BlazinCatFork_P7.Server.Services.SpoonacularApi
{
  using MediatR;
  using System.Collections.Generic;

  public class RecipeSearchRequest : IRequest<RecipeSearchResponse>
  {
    List<string> SearchTerms { get; set; }  
    public int numberOfRecipes { get; set; } = 5;
    public bool limitLicense { get; set; } = false;
    public int ranking { get; set; } = 1; // Whether to maximize used ingredients (1) or minimize missing ingredients (2) first.
    public bool ignorePantry { get; set; } = true;
  }
}


