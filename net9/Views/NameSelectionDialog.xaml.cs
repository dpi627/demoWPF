using System.Windows;
using net9.ViewModels;

namespace net9.Views
{
  public partial class NameSelectionDialog : Window
    {
        private readonly NameSelectionDialogViewModel _viewModel;

        public NameSelectionDialog(string currentName)
      {
        InitializeComponent();
            _viewModel = new NameSelectionDialogViewModel(currentName);
     DataContext = _viewModel;

      // Subscribe to property changes to close dialog
            _viewModel.PropertyChanged += (s, e) =>
            {
    if (e.PropertyName == nameof(_viewModel.DialogResult))
                {
DialogResult = _viewModel.DialogResult;
    Close();
    }
            };
      }

        public string? SelectedName => _viewModel.SelectedName;
    }
}
