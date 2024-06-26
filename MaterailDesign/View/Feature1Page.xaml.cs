using MaterailDesign.ViewModel;
using System.Windows.Controls;

namespace MaterailDesign.View;

public partial class Feature1Page : Page
{
    public Feature1Page()
    {
        InitializeComponent();
        Loaded += Feature1Page_Loaded;
    }

    private async void Feature1Page_Loaded(object sender, System.Windows.RoutedEventArgs e)
    {
        if (DataContext is Feature1ViewModel viewModel)
        {
            await viewModel.InitializeAsync();
        }
    }
}
