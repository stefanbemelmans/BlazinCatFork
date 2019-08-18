namespace BlazinCatFork_P7.Shared.Features.CatPic
{
  using BlazinCatFork_P7.Shared.Features.Base;
  using System.Collections.Generic;

  public class Image
  {
    public string Id { get; set; }
    public string Url { get; set; }
    //public object[] breeds { get; set; }
    //public string[] catagories { get; set; }
  }

  public class SharedSearchResponse : BaseResponse
  {
    public List<Image> Images { get; set; }
  }
}