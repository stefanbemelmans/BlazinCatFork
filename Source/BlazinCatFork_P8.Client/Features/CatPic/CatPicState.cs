namespace BlazinCatFork_P8.Client.Features.CatPic
{
  using BlazorState;

  internal partial class CatPicState : State<CatPicState>
  {
    public System.Uri CatPicUrl { get; set; }

    public CatPicState()
    {
    }

    protected override void Initialize() => CatPicUrl = null;
  }
}