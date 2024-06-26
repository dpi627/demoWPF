using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace MaterailDesign.ViewModel;

public partial class Feature1ViewModel : ObservableObject
{
    [ObservableProperty]
    private string _textBoxContent = string.Empty;

    [ObservableProperty]
    private bool _isToggleOn;

    [ObservableProperty]
    private bool _focusTextBox;

    public Feature1ViewModel()
    {
        IsToggleOnChanged = new RelayCommand(OnIsToggleOnChanged);
    }

    public ICommand IsToggleOnChanged { get; }

    private void OnIsToggleOnChanged()
    {
        if (IsToggleOn)
        {
            SetFocusToTextBox();
        }
    }

    private void SetFocusToTextBox()
    {
        FocusTextBox = false;
        Task.Delay(10).ContinueWith(_ => FocusTextBox = true, TaskScheduler.FromCurrentSynchronizationContext());
    }

    public async Task InitializeAsync()
    {
        // 模擬一些初始化工作
        await Task.Delay(100);

        // 初始化完成後，設置焦點到 TextBox
        SetFocusToTextBox();
    }
}