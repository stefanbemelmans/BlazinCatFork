namespace BlazinCatFork.Client.Features.EventStream.Components
{
  using System.Collections.Generic;
  using BlazinCatFork.Client.Features.Base.Components;

  public class EventStreamModel : BaseComponent
  {
    public IReadOnlyList<string> Events => EventStreamState.Events;

  }
}
