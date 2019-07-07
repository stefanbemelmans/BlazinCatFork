namespace BlazinCatFork.Client.Features.CatPic
{
  using System.Collections.Generic;
  using BlazinCatFork.Shared.Features.CatPic;
  using BlazorState;

  internal partial class CatPicState : State<CatPicState>
  {
    private GetCatPicResponse _CatPic;
    public GetCatPicResponse CatPic { get; set; }

    public CatPicState()
    {
      _CatPic = CatPic;
    }
    protected override void Initialize() { }
  }
}