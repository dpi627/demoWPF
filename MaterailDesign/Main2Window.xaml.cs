using MaterailDesign.ViewModel;
using System.Windows;

namespace MaterailDesign;

/// <summary>
/// Interaction logic for Main2Window.xaml
/// </summary>
public partial class Main2Window : Window
{
    public Main2Window(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
