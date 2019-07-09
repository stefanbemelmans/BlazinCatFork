namespace BlazinCatFork.Server.Features.CatPic
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Threading;
  using System.Threading.Tasks;
  using BlazinCatFork.Shared.Features.CatPic;
  using MediatR;

  public class GetCatPicHandler : IRequestHandler<SearchRequest, SearchResponse>
  {
    public GetCatPicHandler(IMediator aMediator)
    {
      Mediator = aMediator;
    }
    private IMediator Mediator { get; }
    public async Task<SearchResponse> Handle(
      SearchRequest aSearchRequest,
      CancellationToken aCancellationToken)
    {
      SearchResponse SearchResponse = await Mediator.Send(aSearchRequest, aCancellationToken);
      return SearchResponse;
    }
  }
}