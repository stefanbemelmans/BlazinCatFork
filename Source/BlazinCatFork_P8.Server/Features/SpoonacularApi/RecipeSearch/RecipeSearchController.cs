namespace BlazinCatFork_P8.Server.Features.SpoonacularApi.RecipeSearch
{
  using BlazinCatFork_P8.Server.Features.Base;
  using BlazinCatFork_P8.Shared.Features.SpoonacularApi;
  using Microsoft.AspNetCore.Mvc;
  using System.Threading.Tasks;

  public class RecipeSearchController : BaseController<SharedRecipeSearchRequest, SharedRecipeSearchResponse>
  {
    [Route(SharedRecipeSearchRequest.Route)]
    [HttpPost]
    public async Task<IActionResult> Get (SharedRecipeSearchRequest aRequest) => await Send(aRequest);
  }
}
