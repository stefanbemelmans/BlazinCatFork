namespace BlazinCatFork_P8.Server.Features.SpoonacularApi.RecipeSearch
{
    using BlazinCatFork_P8.Server.Services.CatPic;
  using BlazinCatFork_P8.Server.Services.SpoonacularApi;
  using BlazinCatFork_P8.Shared.Features.CatPic;
  using BlazinCatFork_P8.Shared.Features.SpoonacularApi;
  using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class RecipeSearchHandler : IRequestHandler<SharedRecipeSearchRequest, SharedRecipeSearchResponse>
    {
        private IMediator Mediator { get; }

        public RecipeSearchHandler(IMediator aMediator)
        {
            Mediator = aMediator;
        }

        public async Task<SharedRecipeSearchResponse> Handle(
         SharedRecipeSearchRequest aSearchRequest,
          CancellationToken aCancellationToken)
        {
            RecipeSearchResponse searchResponse = await Mediator.Send(new RecipeSearchRequest()
            {
                number = aSearchRequest.number,
                ranking = aSearchRequest.ranking,
                ignorePantry = aSearchRequest.ignorePantry,
                ingredients = aSearchRequest.ingredients
            });


            return new SharedRecipeSearchResponse()
            {
                RecipeSearchResults = searchResponse.RecipeSearchResults
            };
        }
    }
}