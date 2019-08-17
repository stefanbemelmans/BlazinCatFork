﻿namespace BlazinCatfork_P7.Client.Features.Application.Components
{
  using BlazinCatfork_P7.Client.Features.Base.Components;

  public class AccountMenuBase : BaseComponent
  {
    protected void ButtonClick() => Show = !Show;
    protected bool Show { get; set; }
    protected string ShowCssClass => Show ? "show" : null;
  }
}