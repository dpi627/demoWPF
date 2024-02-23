namespace MVVM.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Name { get; set; } = "Unknow";
        public string Message { get; set; } = "Hello, World!";
        public decimal MyValue { get; set; }
    }
}
