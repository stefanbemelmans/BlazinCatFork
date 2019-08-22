namespace BlazinCatFork_P8.Client.Features.CatPic.Components
{
  using BlazinCatFork_P8.Client.Features.Base.Components;
  using System.Threading.Tasks;

  public class CatPicComponentModel : BaseComponent
    {
    public string CatPicUrl => CatPicState.CatPicUrl;

    public async Task NewCat() => await Mediator.Send(new GetCatPicAction());

    protected override async Task OnInitializedAsync() => await NewCat();
  }


}
