namespace BlazinCatFork_P8.EndToEnd.Tests.Infrastructure
{
  using BlazorHostedCSharp.Client.Features.ClientLoader;
  using System;

  public class TestClientLoaderConfiguration : IClientLoaderConfiguration
  {
    public TimeSpan DelayTimeSpan => TimeSpan.FromMilliseconds(10);
  }
}
