using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;

namespace MaterailDesign.ViewModel;

public class MainViewModel : ObservableObject
{
    private ObservableObject _currentViewModel;
    public ObservableObject CurrentViewModel
    {
        get => _currentViewModel;
        set => SetProperty(ref _currentViewModel, value);
    }

    public ICommand ShowFeature1Command { get; }
    public ICommand ShowFeature2Command { get; }

    public MainViewModel()
    {
        ShowFeature1Command = new RelayCommand(ShowFeature1);
        ShowFeature2Command = new RelayCommand(ShowFeature2);
    }

    private void ShowFeature1()
    {
        CurrentViewModel = App.AppHost.Services.GetRequiredService<Feature1ViewModel>();
    }

    private void ShowFeature2()
    {
        CurrentViewModel = App.AppHost.Services.GetRequiredService<Feature2ViewModel>();
    }
}