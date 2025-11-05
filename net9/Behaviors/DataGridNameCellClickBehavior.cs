using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
      AssociatedObject.Loaded += OnDataGridLoaded;
    }

        protected override void OnDetaching()
        {
  base.OnDetaching();
  AssociatedObject.Loaded -= OnDataGridLoaded;
        }

        private void OnDataGridLoaded(object sender, RoutedEventArgs e)
        {
     // Attach click handlers to all edit buttons
     AssociatedObject.AddHandler(ButtonBase.ClickEvent, new RoutedEventHandler(OnButtonClick));
     }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
        // Check if the clicked button is the edit name button
     if (e.OriginalSource is Button button && button.Name == "EditNameButton")
            {
          // Find the User object from the button's DataContext
          if (button.DataContext is User user)
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
