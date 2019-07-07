namespace BlazinCatFork.Server.Features.CatPic
{
  using System.Threading.Tasks;
  using BlazinCatFork.Server.Features.Base;
  using BlazinCatFork.Shared.Features.CatPic;
  using Microsoft.AspNetCore.Mvc;

  [Route(GetCatPicRequest.Route)]
  public class GetCatPicController : BaseController<GetCatPicRequest, GetCatPicResponse>
  {
    public async Task<IActionResult> Get(GetCatPicRequest aRequest) => await Send(aRequest);
  }
}