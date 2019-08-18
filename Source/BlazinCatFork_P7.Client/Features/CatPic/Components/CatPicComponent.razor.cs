using BlazinCatFork_P7.Client.Features.Base.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazinCatFork_P7.Client.Features.CatPic.Components
{
    public class CatPicComponentModel : BaseComponent
    {
    public string CatPicUrl => CatPicState.CatPicUrl;

    public async Task NewCat() => await Mediator.Send(new GetCatPicAction());

    protected override async Task OnInitAsync() => await NewCat();
  }


}
