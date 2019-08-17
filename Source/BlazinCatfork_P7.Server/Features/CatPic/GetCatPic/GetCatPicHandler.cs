namespace BlazinCatFork_P7.Server.Features.CatPic
{
  using System.Threading;
  using System.Threading.Tasks;
  using BlazinCatFork_P7.Shared.Features.CatPic;
  using BlazinCatFork_P7.Server.Services.CatPic;
  using MediatR;

  public class GetCatPicHandler : IRequestHandler<Shared.Features.CatPic.SearchRequest, Shared.Features.CatPic.SearchResponse>
  {
    public GetCatPicHandler(IMediator aMediator)
    {
      Mediator = aMediator;
    }
    private IMediator Mediator { get; }
    public async Task<Shared.Features.CatPic.SearchResponse> Handle(
     Shared.Features.CatPic.SearchRequest aSearchRequest,
      CancellationToken aCancellationToken)
    {
      Services.CatPic.SearchResponse searchResponse = await Mediator.Send(new Services.CatPic.SearchRequest(), aCancellationToken);

      var SharedResponse = new Shared.Features.CatPic.SearchResponse()
      {
        Images = searchResponse.Images
      };

      return SharedResponse;
    }
  }
}