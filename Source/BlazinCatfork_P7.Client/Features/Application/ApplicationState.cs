namespace BlazinCatfork_P7.Client.Features.Application
{
  using BlazorState;

  internal partial class ApplicationState : State<ApplicationState>
  {

    public string Name { get; private set; }
    public string Logo { get; private set; }
    public bool IsMenuExpanded { get; private set; }

    public string Version => GetType().Assembly.GetName().Version.ToString();
    
    public ApplicationState() { }

    protected override void Initialize()
    {
      IsMenuExpanded = true;
      Name = "BlazinCatfork_P7";
      Logo = "/images/logo.png";
    }

  }
}