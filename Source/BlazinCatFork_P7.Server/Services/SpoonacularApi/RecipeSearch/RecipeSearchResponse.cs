using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazinCatFork_P7.Shared.Features.SpoonacularApi.RecipeSearch;
namespace BlazinCatFork_P7.Server.Services.SpoonacularApi
{
  public class RecipeSearchResponse
  {
   List<RecipePreview> SearchResults { get; set; }
  }
}
