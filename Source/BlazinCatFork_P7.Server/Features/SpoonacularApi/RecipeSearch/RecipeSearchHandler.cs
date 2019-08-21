namespace BlazinCatFork_P7.Server.Features.RecipeSearch
{
    using BlazinCatFork_P7.Server.Services.CatPic;
    using BlazinCatFork_P7.Shared.Features.CatPic;
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

        public async Task<SharedSearchResponse> Handle(
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


            return new SharedResponse()
            {
                RecipeSearchResults = searchResponse.RecipeSearchResults
            };
        }
    }
}