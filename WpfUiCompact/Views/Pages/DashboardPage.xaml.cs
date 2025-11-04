using Wpf.Ui.Abstractions.Controls;
using WpfUiCompact.ViewModels.Pages;

namespace WpfUiCompact.Views.Pages
{
    public partial class DashboardPage : INavigableView<DashboardViewModel>
    {
        public DashboardViewModel ViewModel { get; }

        public DashboardPage(DashboardViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
