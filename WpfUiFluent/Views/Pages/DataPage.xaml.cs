using Wpf.Ui.Abstractions.Controls;
using WpfUiFluent.ViewModels.Pages;

namespace WpfUiFluent.Views.Pages
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
