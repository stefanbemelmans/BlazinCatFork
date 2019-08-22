using BlazinCatFork_P8.Shared.Features.Base;
using System.Collections.Generic;

namespace BlazinCatFork_P8.Shared.Features.SpoonacularApi
{
  public class SharedRecipeSearchResponse : BaseResponse
  {
    public List<RecipeSearchResult> RecipeSearchResults { get; set; }
  }
}