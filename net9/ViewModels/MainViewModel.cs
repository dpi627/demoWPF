using CommunityToolkit.Mvvm.ComponentModel;
using net9.Models;
using System.Collections.ObjectModel;

namespace net9.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<User> users;

        [ObservableProperty]
        private UserProfile currentUser;

        [ObservableProperty]
        private bool isUserPopupOpen;

        public MainViewModel()
        {
            // Initialize with mock user profile data
            currentUser = new UserProfile
            {
                ImageUrl = "https://i.pravatar.cc/150?img=12",
                Username = "Brian Chen",
                EmpNo = "EMP-2024-0042",
                Email = "brian.chen@company.com",
                Level = 15,
                ExpPercentage = 72.5
            };

            // Initialize with mock data
            users = new ObservableCollection<User>
            {
                new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
                new User { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" },
                new User { Id = 3, Name = "Bob Johnson", Email = "bob.johnson@example.com" },
                new User { Id = 4, Name = "Alice Williams", Email = "alice.williams@example.com" },
                new User { Id = 5, Name = "Charlie Brown", Email = "charlie.brown@example.com" },
                new User { Id = 6, Name = "Diana Prince", Email = "diana.prince@example.com" },
                new User { Id = 7, Name = "Ethan Hunt", Email = "ethan.hunt@example.com" },
                new User { Id = 8, Name = "Fiona Green", Email = "fiona.green@example.com" }
            };
        }
    }
}
