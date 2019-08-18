namespace BlazinCatFork_P7.Client.Features.CatPic
{
  using BlazorState;

  internal partial class CatPicState : State<CatPicState>
  {
    public string CatPicUrl { get; set; }

    public CatPicState()
    {
    }

    protected override void Initialize() => CatPicUrl = null;
  }
}