using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MaterailDesign.View;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Controls;

namespace MaterailDesign.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _isLeftDrawerOpen;

    [ObservableProperty]
    private Page? _currentPage;

    public MainViewModel()
    {
        NavigateToFeature1();
    }

    [RelayCommand]
    private void NavigateToFeature1()
    {
        CurrentPage = App.AppHost.Services.GetRequiredService<Feature1Page>();
        CloseLeftDrawer();
    }

    [RelayCommand]
    private void NavigateToFeature2()
    {
        CurrentPage = App.AppHost.Services.GetRequiredService<Feature2Page>();
        CloseLeftDrawer();
    }

    private void CloseLeftDrawer()
    {
        IsLeftDrawerOpen = false;
    }
}