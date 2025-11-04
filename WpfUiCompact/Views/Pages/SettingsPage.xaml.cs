using Wpf.Ui.Abstractions.Controls;
using WpfUiCompact.ViewModels.Pages;

namespace WpfUiCompact.Views.Pages
{
    public partial class SettingsPage : INavigableView<SettingsViewModel>
    {
        public SettingsViewModel ViewModel { get; }

        public SettingsPage(SettingsViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
