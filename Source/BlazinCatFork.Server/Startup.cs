namespace BlazinCatFork.Server
{
  using BlazorState;
  using MediatR;
  using Microsoft.AspNetCore.Builder;
  using Microsoft.AspNetCore.Hosting;
  using Microsoft.AspNetCore.ResponseCompression;
  using Microsoft.Extensions.DependencyInjection;
  using Microsoft.Extensions.Hosting;
  using System.Linq;
  using System.Reflection;
  using BlazinCatFork.Server.Services.CatPic;

  public class Startup
  {
    public void Configure
    (
      IApplicationBuilder aApplicationBuilder,
      IWebHostEnvironment aWebHostEnvironment
    )
    {
      aApplicationBuilder.UseResponseCompression();

      if (aWebHostEnvironment.IsDevelopment())
      {
        aApplicationBuilder.UseDeveloperExceptionPage();
        aApplicationBuilder.UseBlazorDebugging();
      }

      aApplicationBuilder.UseRouting();
      aApplicationBuilder.UseEndpoints
      (
        aEndpointRouteBuilder =>
        {
          aEndpointRouteBuilder.MapControllers(); // We use explicit attribute routing so dont need MapDefaultControllerRoute
          aEndpointRouteBuilder.MapBlazorHub();
          aEndpointRouteBuilder.MapFallbackToPage("/_Host");
        }
      );
      aApplicationBuilder.UseClientSideBlazorFiles<Client.Startup>();
    }

    public void ConfigureServices(IServiceCollection aServiceCollection)
    {
      aServiceCollection.AddRazorPages();
      aServiceCollection.AddServerSideBlazor();

      aServiceCollection.AddMvc();

      aServiceCollection.AddResponseCompression
      (
        aResponseCompressionOptions =>
          aResponseCompressionOptions.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat
          (
            new[] { "application/octet-stream" }
          )
      );

      aServiceCollection.AddBlazorState
      (
        (aOptions) => aOptions.Assemblies =
          new Assembly[]
          {
            typeof(Client.Startup).GetTypeInfo().Assembly
          }
      );

      new Client.Startup().ConfigureServices(aServiceCollection);

      aServiceCollection.AddMediatR(typeof(Startup).GetTypeInfo().Assembly);
      aServiceCollection.AddHttpClient();
      aServiceCollection.AddScoped<CatPicHttpClient>();

      // experimenting with setting custom header

      //aServiceCollection.AddHttpClient("CatPic", c =>
      //{
      //  c.BaseAddress = new System.Uri("https://api.thecatapi.com/v1/images/search?size=med");
      //  c.DefaultRequestHeaders.Add("x-api", "23e061a5-c2d3-480e-8105-2fd0fb96a6aa");
      //}
      //  );

      aServiceCollection.Scan
      (
        aTypeSourceSelector => aTypeSourceSelector
          .FromAssemblyOf<Startup>()
          .AddClasses()
          .AsSelf()
          .WithScopedLifetime()
      );
    }
  }
}