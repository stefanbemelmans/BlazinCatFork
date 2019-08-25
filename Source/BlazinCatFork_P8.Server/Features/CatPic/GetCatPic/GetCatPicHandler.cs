namespace BlazinCatFork_P8.Server.Features.CatPic
{
  using BlazinCatFork_P8.Server.Services.CatPic;
  using BlazinCatFork_P8.Shared.Features.CatPic;
  using MediatR;
  using System.Threading;
  using System.Threading.Tasks;

  public class GetCatPicHandler : IRequestHandler<SharedSearchRequest, SharedSearchResponse>
  {
    private IMediator Mediator { get; }

    public GetCatPicHandler(IMediator aMediator)
    {
      Mediator = aMediator;
    }

    public async Task<SharedSearchResponse> Handle(
     SharedSearchRequest aSearchRequest,
      CancellationToken aCancellationToken)
    {
      SearchResponse searchResponse = await Mediator.Send(new SearchRequest());

      var sharedResponse = new SharedSearchResponse()
      {
        Images = searchResponse.Images
      };

      return sharedResponse;
    }
  }
}