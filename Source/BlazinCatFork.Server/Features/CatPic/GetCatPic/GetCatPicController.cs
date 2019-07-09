namespace BlazinCatFork.Server.Features.CatPic
{
  using System.Threading.Tasks;
  using BlazinCatFork.Server.Features.Base;
  using BlazinCatFork.Shared.Features.CatPic;
  using Microsoft.AspNetCore.Mvc;

  [Route(SearchRequest.Route)]
  public class CatPicSearchController : BaseController<SearchRequest, SearchResponse>
  {
    public async Task<IActionResult> Get(SearchRequest aRequest) => await Send(aRequest);
  }
}