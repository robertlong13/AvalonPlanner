using System.Collections.ObjectModel;
using Avalonia.Controls;
using ReactiveUI;

namespace AvalonPlanner.ViewModels;

public class MainViewModel : ViewModelBase
{
    public ObservableCollection<INavigationPage> Pages { get; private set; }
    public ObservableCollection<INavigationPage> FooterPages { get; private set; }

    private INavigationPage? _selectedPage;
    public INavigationPage? SelectedPage
    {
        get => _selectedPage;
        set
        {
            if (_selectedPage != value)
            {
                this.RaiseAndSetIfChanged(ref _selectedPage, value);
                this.RaisePropertyChanged(nameof(CurrentPageContent));
            }
        }

    }
    public UserControl? CurrentPageContent => SelectedPage?.PageContent;

    public MainViewModel()
    {
        Pages = [
            new FlightDataViewModel(),
            new FlightPlanViewModel()
        ];
        FooterPages = [
            new SettingsViewModel()
        ];
        SelectedPage = Pages[0];
    }

    private UserControl? _currentContent;
    public UserControl? CurrentContent
    {
        get => _currentContent;
        set => this.RaiseAndSetIfChanged(ref _currentContent, value);
    }
}
