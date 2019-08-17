namespace BlazinCatFork_P7.Server.Services.CatPic
{
  using MediatR;
 
    public class SearchRequest : IRequest<SearchResponse>
    {
      public string Size { get; set; } = "med"; // full med small thumb
      public int Limit { get; set; } = 1; // min 1 max 100

      public string SearchUrl => $"/v1/images/search?size={Size}&&limit={Limit}";
    }
}
