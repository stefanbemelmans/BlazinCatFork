﻿namespace BlazinCatfork.Client.Features.EventStream.Components
{
  using System.Collections.Generic;
  using BlazinCatfork.Client.Features.Base.Components;

  public class EventStreamBase : BaseComponent
  {
    public IReadOnlyList<string> Events => EventStreamState.Events;
  }
}
