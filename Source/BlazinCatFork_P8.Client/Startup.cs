namespace BlazinCatFork_P8.Client
{
  using BlazinCatFork_P8.Client.Features.Application;
  using BlazinCatFork_P8.Client.Features.CatPic;
  using BlazinCatFork_P8.Client.Features.Counter;
  using BlazinCatFork_P8.Client.Features.EventStream;
  using BlazinCatFork_P8.Client.Features.Recipes;
  using BlazinCatFork_P8.Client.Features.WeatherForecast;
  using BlazorHostedCSharp.Client.Features.ClientLoader;
  using BlazorState;
  using MediatR;
  using Microsoft.AspNetCore.Components.Builder;
  using Microsoft.Extensions.DependencyInjection;
  using System.Reflection;
  using System.Text.Json;

  public class Startup
  {
    public void Configure(IComponentsApplicationBuilder aComponentsApplicationBuilder) =>
      aComponentsApplicationBuilder.AddComponent<App>("app");

    public void ConfigureServices(IServiceCollection aServiceCollection)
    {
      aServiceCollection.AddBlazorState
      (
        (aOptions) => aOptions.Assemblies =
          new Assembly[] 
          {
            typeof(Startup).GetTypeInfo().Assembly,
          }
      );

      aServiceCollection.AddSingleton
      (
        new JsonSerializerOptions
        {
          PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        }
      );

      aServiceCollection.AddScoped(typeof(IPipelineBehavior<,>), typeof(EventStreamBehavior<,>));
      aServiceCollection.AddScoped<ClientLoader>();
      aServiceCollection.AddScoped<IClientLoaderConfiguration, ClientLoaderConfiguration>();
      
      aServiceCollection.AddTransient<ApplicationState>();
      aServiceCollection.AddTransient<CounterState>();
      aServiceCollection.AddTransient<EventStreamState>();
      aServiceCollection.AddTransient<WeatherForecastsState>();
      aServiceCollection.AddTransient<CatPicState>();
      aServiceCollection.AddTransient<RecipeState>();
    }
  }
}