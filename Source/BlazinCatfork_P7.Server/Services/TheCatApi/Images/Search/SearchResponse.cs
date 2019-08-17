namespace BlazinCatFork_P7.Server.Services.CatPic
{
  using BlazinCatFork_P7.Shared.Features.CatPic;
  using System.Collections.Generic;
  using static BlazinCatFork_P7.Shared.Features.CatPic.SearchResponse;

  public class SearchResponse
  {
   public List<Image> Images { get; set; }
   

  }
}
