namespace BlazinCatFork_P8.Client.Features.CatPic
{
  using BlazinCatFork_P8.Shared.Features.Base;
  using MediatR;

  public class GetCatPicAction : BaseRequest, IRequest<CatPicState> { };
}

