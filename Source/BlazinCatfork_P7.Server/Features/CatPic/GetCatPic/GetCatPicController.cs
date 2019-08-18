namespace BlazinCatFork_P7.Server.Features.CatPic
{
  using System.Threading.Tasks;
  using BlazinCatFork_P7.Server.Features.Base;
  using BlazinCatFork_P7.Shared.Features.CatPic;
  using Microsoft.AspNetCore.Mvc;

  [Route(SharedSearchRequest.Route)]
  public class CatPicSearchController : BaseController<SharedSearchRequest, SharedSearchResponse>
  {
    public async Task<IActionResult> Get(SharedSearchRequest aRequest) => await Send(aRequest);
  }
}