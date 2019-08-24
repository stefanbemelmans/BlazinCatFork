namespace BlazinCatFork_P8.Client.Features.CatPic.Components
{
  using BlazinCatFork_P8.Client.Features.Base.Components;
  using System.Threading.Tasks;

  public class CatPicComponentBase : BaseComponent
    {
    public System.Uri CatPicUrl => CatPicState.CatPicUrl;

    public async Task NewCat() => await Mediator.Send(new GetCatPicAction()).ConfigureAwait(true);

    protected override async Task OnInitializedAsync() => await NewCat().ConfigureAwait(true);
  }


}
