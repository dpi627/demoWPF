using CommunityToolkit.Mvvm.ComponentModel;

namespace net9.Models
{
  public partial class User : ObservableObject
    {
        [ObservableProperty]
     private int id;

   [ObservableProperty]
        private string name = string.Empty;

  [ObservableProperty]
  private string email = string.Empty;
    }
}
