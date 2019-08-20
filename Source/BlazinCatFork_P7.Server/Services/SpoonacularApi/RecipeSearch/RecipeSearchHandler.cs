using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace BlazinCatFork_P7.Server.Services.SpoonacularApi
{
  public class RecipeSearchHandler : IRequestHandler<RecipeSearchRequest, RecipeSearchResponse>
  {
    public Task<RecipeSearchResponse> Handle(RecipeSearchRequest request, CancellationToken cancellationToken) => throw new System.NotImplementedException();
  }
}
