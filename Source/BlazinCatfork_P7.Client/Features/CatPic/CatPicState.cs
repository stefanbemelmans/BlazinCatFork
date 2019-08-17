namespace BlazinCatFork.Client.Features.CatPic
{
  using System.Collections.Generic;
  using BlazinCatFork.Shared.Features.CatPic;
  using BlazorState;
  using static BlazinCatFork.Shared.Features.CatPic.SearchResponse;

  internal partial class CatPicState : State<CatPicState>
  {
    //private SearchResponse _CatPic;

    public string CatPicUrl { get;set; }
    public CatPicState()
    {
      //CatPicUrl = _CatPic.Images[0].Url;
    }
    protected override void Initialize() { }
  }
}