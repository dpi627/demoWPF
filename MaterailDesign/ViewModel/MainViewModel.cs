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

    [ObservableProperty]
    private bool _isLoading;

    public IAsyncRelayCommand NavigateToFeature1AsyncCommand { get; }
    public IAsyncRelayCommand NavigateToFeature2AsyncCommand { get; }

    public MainViewModel()
    {
        NavigateToFeature1AsyncCommand = new AsyncRelayCommand(NavigateToFeature1Async);
        NavigateToFeature2AsyncCommand = new AsyncRelayCommand(NavigateToFeature2Async);
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

    private async Task NavigateToFeature1Async()
    {
        await NavigateToPageAsync<Feature1Page>();
    }

    private async Task NavigateToFeature2Async()
    {
        await NavigateToPageAsync<Feature2Page>();
    }

    private async Task NavigateToPageAsync<T>() where T : Page
    {
        IsLoading = true;
        IsLeftDrawerOpen = false;

        try
        {
            // 模擬頁面載入時間
            await Task.Delay(1000);
            CurrentPage = App.AppHost!.Services.GetRequiredService<T>();
        }
        finally
        {
            IsLoading = false;
        }
    }
}