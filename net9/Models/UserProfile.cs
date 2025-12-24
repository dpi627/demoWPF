using CommunityToolkit.Mvvm.ComponentModel;

namespace net9.Models
{
    public partial class UserProfile : ObservableObject
    {
        [ObservableProperty]
        private string imageUrl = string.Empty;

        [ObservableProperty]
        private string username = string.Empty;

        [ObservableProperty]
        private string empNo = string.Empty;

        [ObservableProperty]
        private string email = string.Empty;

        [ObservableProperty]
        private int level;

        [ObservableProperty]
        private double expPercentage;
    }
}
