namespace BlazinCatFork_P7.Client.Features.EventStream.Components
{
  using System.Collections.Generic;
  using BlazinCatFork_P7.Client.Features.Base.Components;

  public class EventStreamBase : BaseComponent
  {
    public IReadOnlyList<string> Events => EventStreamState.Events;

  }
}
