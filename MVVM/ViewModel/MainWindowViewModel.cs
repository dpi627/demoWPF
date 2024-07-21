using MVVM.Command;
using System.Windows.Input;

namespace MVVM.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            ChangeMessage = new RelayCommand<string>(param=> this.Message = param);
            KeyDownCommand = new RelayCommand<KeyEventArgs>(KeyDownExecute);
        }
        public string Name { get; set; } = "Unknow";
        public string Message { get; set; } = "Hello, World!";
        public decimal MyValue { get; set; }
        public required ICommand ChangeMessage { get; set; }
        public required ICommand KeyDownCommand { get; set; }

        private void KeyDownExecute(KeyEventArgs e)
        {
            // 實現按鍵按下時的邏輯
            Message = $"KeyDown: {e.Key}";
        }
    }
}
