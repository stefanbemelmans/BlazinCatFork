namespace BlazinCatfork.Api.Features.CatPic
{
  using BlazinCatfork.Api.Features.Base;
  using System.Collections.Generic;

  public class Image
  {
    public string Id { get; set; }
    public System.Uri Url { get; set; }
    //public object[] breeds { get; set; }
    //public string[] catagories { get; set; }
  }

  public class SharedSearchResponse : BaseResponse
  {
    public List<Image> Images { get; set; }
  }
}