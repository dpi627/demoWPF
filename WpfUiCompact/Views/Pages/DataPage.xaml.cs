using Wpf.Ui.Abstractions.Controls;
using WpfUiCompact.ViewModels.Pages;

namespace WpfUiCompact.Views.Pages
{
    public partial class DataPage : INavigableView<DataViewModel>
    {
        public DataViewModel ViewModel { get; }

        public DataPage(DataViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
