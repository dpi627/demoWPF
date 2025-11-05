using System.Windows;
using net9.ViewModels;
using net9.Views;

namespace net9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void OpenChartsButton_Click(object sender, RoutedEventArgs e)
        {
            var chartsWindow = new ChartsWindow();
            chartsWindow.Show();
        }
    }
}