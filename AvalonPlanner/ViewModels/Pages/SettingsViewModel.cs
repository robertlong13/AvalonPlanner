using Avalonia.Controls;
using FluentAvalonia.UI.Controls;

namespace AvalonPlanner.ViewModels;

public class SettingsViewModel : INavigationPage
{
    public string Name => "Settings";
    public IconSource Icon => new SymbolIconSource() { Symbol = Symbol.Setting };
    public UserControl PageContent => new SettingsView();
}
