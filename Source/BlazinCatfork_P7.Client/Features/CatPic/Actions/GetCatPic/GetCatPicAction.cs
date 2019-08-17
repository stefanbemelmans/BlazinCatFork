namespace BlazinCatFork_P7.Client.Features.CatPic
{
  using BlazinCatFork_P7.Shared.Features.Base;
  using MediatR;

  public class GetCatPicAction : BaseRequest, IRequest<CatPicState> { };
}

