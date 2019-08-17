namespace BlazinCatFork_P7.Server.Features.CatPic
{
  using System.Threading.Tasks;
  using BlazinCatFork_P7.Server.Features.Base;
  using BlazinCatFork_P7.Shared.Features.CatPic;
  using Microsoft.AspNetCore.Mvc;

  [Route(SearchRequest.Route)]
  public class CatPicSearchController : BaseController<SearchRequest, SearchResponse>
  {
    public async Task<IActionResult> Get(SearchRequest aRequest) => await Send(aRequest);
  }
}