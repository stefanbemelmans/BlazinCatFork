namespace BlazinCatfork.EndToEnd.Tests.Infrastructure
{
  using BlazinCatfork.Client.Features.ClientLoaderFeature;
  using System;

  public class TestClientLoaderConfiguration : IClientLoaderConfiguration
  {
    public TimeSpan DelayTimeSpan => TimeSpan.FromMilliseconds(10);
  }
}
