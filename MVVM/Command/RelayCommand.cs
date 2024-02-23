using System.Windows.Input;

namespace MVVM.Command
{
    /**************************************************************************************************
     * https://yuchungchuang.wordpress.com/2019/06/26/wpf-mvvm-relaycommand/
     * 參考上述網址 > 透過 GitHub Copilot Chat 優化 > 透過 VS2022 優化
     * 透過將方法傳入 RelayCommand 處理，簡化程式，不用每個命令都實作 ICommand
     *
     * https://yuchungchuang.wordpress.com/2019/06/26/wpf-mvvm-commandparameter/
     * 該為支援參數傳入，object > T (Generic Type)
     **/

    public class RelayCommand<T> : ICommand where T : class
    {
        private readonly Action<T> _execute;
        private readonly Func<T, bool>? _canExecute;

        public RelayCommand(Action<T> execute, Func<T, bool>? canExecute = null)
        {
            _execute = execute ?? throw new System.ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter as T) ?? true;

        public void Execute(object? parameter)
        {
            if (CanExecute(parameter))
            {
                _execute(parameter as T);
            }
        }

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
