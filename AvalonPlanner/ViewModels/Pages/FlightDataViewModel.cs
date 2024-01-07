using Avalonia.Controls;
using FluentAvalonia.UI.Controls;

namespace AvalonPlanner.ViewModels;

public class FlightDataViewModel : INavigationPage
{
    public string Name => "Flight Data";
    public IconSource Icon => new SymbolIconSource() { Symbol = Symbol.Send };
    public UserControl PageContent => new FlightDataView();
}
