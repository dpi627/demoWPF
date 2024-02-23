using System.Windows.Input;

namespace MVVM.Command
{
    /**************************************************************************************************
     * https://yuchungchuang.wordpress.com/2019/06/26/wpf-mvvm-viewmodel/
     *
     * CommandBase 實作 ICommand 介面，包含三個規範
     * 定義為抽象(abstract)類別，只能被繼承，無法實例化
     *
     * CanExecute 方法預設為 true，因為命命大部分可以執行
     * 關鍵字 virtual 表示該方法可以被子類別覆寫，增加使用彈性
     *
     * Execute 方法為抽象(abstract)方法，必須由子類別實作
     * 方法改為抽象，不用實作 IComnnad 規範
     **/

    /// <summary>
    /// Base class for all commands.
    /// </summary>
    public abstract class CommandBase : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public virtual bool CanExecute(object? parameter) { return true; }

        public abstract void Execute(object? parameter);
    }
}
