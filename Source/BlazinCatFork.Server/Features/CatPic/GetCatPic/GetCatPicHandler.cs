namespace BlazinCatFork.Server.Features.CatPic
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Threading;
  using System.Threading.Tasks;
  using BlazinCatFork.Shared.Features.CatPic;
  using MediatR;

  public class GetCatPicHandler : IRequestHandler<GetCatPicRequest, GetCatPicResponse>
  {
    public GetCatPicHandler(IMediator aMediator)
    {
      Mediator = aMediator;
    }
    private IMediator Mediator { get; }
    public async Task<GetCatPicResponse> Handle(
      GetCatPicRequest aGetCatPicRequest,
      CancellationToken aCancellationToken)
    {
      GetCatPicResponse getCatPicResponse = await Mediator.Send(aGetCatPicRequest, aCancellationToken);
      return getCatPicResponse;
    }
  }
}