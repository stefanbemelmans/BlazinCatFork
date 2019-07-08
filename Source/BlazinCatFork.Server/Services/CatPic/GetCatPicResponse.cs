using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazinCatFork.Server.Services.CatPic
{
  public class GetCatPicResponse
  { public string id { get; set; }
    public string url { get; set; }
    public string[] breeds { get; set; }
    public string[] catagories { get; set; }

  }
}
