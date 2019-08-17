namespace BlazinCatfork_P7.Client.Features.CatPic
{
  using BlazinCatFork.Client.Features.CatPic;
  using BlazinCatfork_P7.Shared.Features.Base;
  using MediatR;

  public class GetCatPicAction : BaseRequest, IRequest<CatPicState>
  {
    public GetCatPicAction() { }
  }
}
