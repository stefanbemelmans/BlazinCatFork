﻿namespace BlazinCatFork.Shared.Features.CatPic
{
  using BlazinCatfork_P7.Shared.Features.Base;
  using System.Collections.Generic;

  public class SearchResponse : BaseResponse
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