namespace BlazinCatFork_P8.Client.Features.Application.Components
{
  using BlazinCatFork_P8.Client.Features.Base.Components;

  public class AccountMenuBase : BaseComponent
  {
    protected void ButtonClick() => Show = !Show;
    protected bool Show { get; set; }
    protected string ShowCssClass => Show ? "show" : null;
  }
}
