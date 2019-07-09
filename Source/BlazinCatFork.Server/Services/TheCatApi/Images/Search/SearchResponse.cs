namespace BlazinCatFork.Server.Services.CatPic
{
  using System.Collections.Generic;
  public class SearchResponse
  {
   public List<Image> Images { get; set; }
    public class Image
    {
      public string Id { get; set; }
      public string Url { get; set; }
      //public object[] breeds { get; set; }
      //public string[] catagories { get; set; }

    }

  }
}
