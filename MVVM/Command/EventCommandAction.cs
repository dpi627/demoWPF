using System.Windows;
using System.Windows.Input;
using Microsoft.Xaml.Behaviors;

namespace MVVM.Command
{
    /**************************************************************************************************
     * https://yuchungchuang.wordpress.com/2019/06/28/wpf-mvvm-eventcommandaction/
     * 參考 GPT 參考 GPT 建議導入 Microsoft.Xaml.Behaviors，非原文 Interactivity
     * WPF 沒有內建方法傳遞事件參數到 ViewModel，導入後可在 View 綁定事件與命令
     * 再透過 EventCommandAction 將事件參數傳遞到 ViewModel
     **/

    public class EventCommandAction : TriggerAction<DependencyObject>
    {
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register(
                       "Command", typeof(ICommand), typeof(EventCommandAction), new PropertyMetadata(null));

        protected override void Invoke(object parameter)
        {
            if (Command != null && Command.CanExecute(parameter))
            {
                Command.Execute(parameter);
            }
        }
    }
}
