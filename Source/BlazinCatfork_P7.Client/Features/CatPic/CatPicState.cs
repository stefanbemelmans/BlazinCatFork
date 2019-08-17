namespace BlazinCatFork_P7.Client.Features.CatPic
{
  using BlazorState;

  internal partial class CatPicState : State<CatPicState>
  {
    //private SearchResponse _CatPic;
    public string CatUrl { get; set; }
    public string CatPicUrl { get; set; }

    public CatPicState()
    {
      //CatPicUrl = _CatPic.Images[0].Url;
    }

    protected override void Initialize() => CatUrl = null;
  }
}