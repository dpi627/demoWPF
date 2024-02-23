using System.Windows.Input;

namespace MVVM.Command
{
    /**************************************************************************************************
     * https://yuchungchuang.wordpress.com/2019/06/26/wpf-mvvm-relaycommand/
     * 參考上述網址 > 透過 GitHub Copilot Chat 優化 > 透過 VS2022 優化
     * 透過將方法傳入 RelayCommand 處理，簡化程式，不用每個命令都實作 ICommand
     **/

    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool>? _canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool>? canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? true;

        public void Execute(object? parameter)
        {
            if (CanExecute(parameter))
            {
                _execute(parameter);
            }
        }

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
