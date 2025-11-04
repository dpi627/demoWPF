using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using net9.Models;
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

        private void UsersDataGrid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Get the clicked element
            var dep = (DependencyObject)e.OriginalSource;

            // Find the DataGridCell
            while (dep != null && dep is not DataGridCell)
            {
                dep = VisualTreeHelper.GetParent(dep);
            }

            if (dep is DataGridCell cell)
            {
                // Check if the clicked cell is in the Name column
                var column = cell.Column;
                if (column != null && column.Header?.ToString() == "Name")
                {
                    // Get the User object from the row
                    if (UsersDataGrid.SelectedItem is User user)
                    {
                        // Show the name selection dialog
                        var dialog = new NameSelectionDialog(user.Name)
                        {
                            Owner = this
                        };

                        if (dialog.ShowDialog() == true && !string.IsNullOrEmpty(dialog.SelectedName))
                        {
                            // Update the user's name
                            user.Name = dialog.SelectedName;
                        }
                    }
                }
            }
        }
    }
}