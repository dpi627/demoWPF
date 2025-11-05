using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace net9.ViewModels
{
    public partial class NameSelectionDialogViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<string> availableNames;

        [ObservableProperty]
        private string? selectedName;

        [ObservableProperty]
        private bool? dialogResult;

        public NameSelectionDialogViewModel(string currentName)
        {
            availableNames = new ObservableCollection<string>
            {
                "John Doe",
                "Jane Smith",
                "Bob Johnson"
            };

            // Set current name as selected if it exists in the list
            if (availableNames.Contains(currentName))
            {
                selectedName = currentName;
            }
        }

        [RelayCommand]
        private void Ok()
        {
            DialogResult = true;
        }

        [RelayCommand]
        private void Cancel()
        {
            DialogResult = false;
        }
    }
}
