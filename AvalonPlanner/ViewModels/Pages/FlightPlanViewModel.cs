using Avalonia.Controls;
using FluentAvalonia.UI.Controls;

namespace AvalonPlanner.ViewModels;

public class FlightPlanViewModel : INavigationPage
{
    public string Name => "Flight Plan";
    public IconSource Icon => new SymbolIconSource() { Symbol = Symbol.Map };
    public UserControl PageContent => new FlightPlanView();
}
