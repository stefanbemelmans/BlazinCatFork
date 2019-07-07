namespace BlazinCatFork.Client.Features.CatPic
{
  using System.Collections.Generic;
  using BlazinCatFork.Shared.Features.CatPic;
  using BlazorState;

  internal partial class CatPicState : State<CatPicState>
  {
    private CatPicDto _CatPic;

    public CatPicDto CatPic => _CatPic.AsReadOnly();

    public CatPicState()
    {
      _CatPic = new CatPicDto();
    }
    protected override void Initialize() { }
  }
}