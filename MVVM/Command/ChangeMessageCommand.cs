using MVVM.ViewModel;

namespace MVVM.Command
{
    public class ChangeMessageCommand(MainWindowViewModel vm) : CommandBase
    {
        private readonly MainWindowViewModel _vm = vm;

        public override void Execute(object? parameter)
        {
            _vm.Message = "Hello, MVVM!";
        }
    }
}
