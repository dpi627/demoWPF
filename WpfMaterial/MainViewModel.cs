using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfMaterial;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(IncrementCountCommand))]
    private int _count;

    [ObservableProperty]
    private bool isLeftDrawerOpened;

    public MainViewModel()
    {

    }

    [RelayCommand(CanExecute = nameof(CanIncrementCount))]
    private void IncrementCount()
    {
        Count++;
    }

    private bool CanIncrementCount() => Count < 5;

    [RelayCommand]
    private void ClearedCount()
    {
        Count = 0;
    }

    [RelayCommand]
    private void OpenDrawer()
    {
        IsLeftDrawerOpened = true;
    }

    [RelayCommand]
    private void CloseDrawer()
    {
        IsLeftDrawerOpened = false;
    }
}
