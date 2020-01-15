namespace BlazinCatfork.Api.Features.CatPic
{
  using BlazinCatfork.Api.Features.Base;
  using MediatR;

  public class SharedSearchRequest : BaseRequest, IRequest<SharedSearchResponse>
  {
    public const string Route = "api/catPic"; 
    public string Size { get; set; } = "med"; // full med small thumb
    public int Limit { get; set; } = 1; // min 1 max 100

#pragma warning disable CA1056 // Uri properties should not be strings


    public string SearchUrl => Route + "/v1/images/search?size={Size}&&limit={Limit}";
#pragma warning restore CA1056 // Uri properties should not be strings
  }
}