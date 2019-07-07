namespace BlazinCatFork.Shared.Features.CatPic
{
  using BlazinCatFork.Shared.Features.Base;
  using MediatR;

  public class GetCatPicRequest : BaseRequest, IRequest<GetCatPicResponse>
  {
    public const string Route = "api/CatPic";

  }
}