namespace BlazinCatfork.Api.Features.SpoonacularApi
{
  using BlazinCatfork.Api.Features.Base;
  using System.Collections.Generic;

  public class SharedRecipeSearchResponse : BaseResponse
  {
    public List<RecipeSearchResult> RecipeSearchResults { get; set; }
  }
}