using Avalonia.Controls;
using FluentAvalonia.UI.Controls;

namespace AvalonPlanner.ViewModels;

public interface INavigationPage
{
    public string? Name { get; }
    public IconSource Icon { get; }
    public UserControl? PageContent { get; }
}
