namespace BlazinCatFork_P7.Shared.Features.CatPic
{
  using BlazinCatFork_P7.Shared.Features.Base;
  using MediatR;

  public class SearchRequest : BaseRequest, IRequest<SearchResponse>
  {
    public const string Route = "api/catpic"; 
    public string Size { get; set; } = "med"; // full med small thumb
    public int Limit { get; set; } = 1; // min 1 max 100

    public string SearchUrl => $"/v1/images/search?size={Size}&&limit={Limit}";
  }
}