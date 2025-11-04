using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using net9.Models;
using net9.Views;

namespace net9.Behaviors
{
    public class DataGridNameCellClickBehavior : Behavior<DataGrid>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.PreviewMouseLeftButtonDown += OnPreviewMouseLeftButtonDown;
        }

     protected override void OnDetaching()
        {
       base.OnDetaching();
            AssociatedObject.PreviewMouseLeftButtonDown -= OnPreviewMouseLeftButtonDown;
        }

        private void OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
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
        if (AssociatedObject.SelectedItem is User user)
           {
     // Show the name selection dialog
 var dialog = new NameSelectionDialog(user.Name)
       {
             Owner = Window.GetWindow(AssociatedObject)
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
