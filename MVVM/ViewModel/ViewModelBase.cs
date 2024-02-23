using System.ComponentModel;

namespace MVVM.ViewModel
{
    /***********************************************************************************************************
     * ViewModelBase 定義為抽象(abstract)類別，只能被繼承，無法實例化，適合做為基底類別
     * 實作 INotifyPropertyChanged 介面。讓 ViewModel 可以通知 View 屬性值的變更
     * ViewModel 可視為 DataBinding 之中的 DataContext
     * OnPropertyChanged 的訪問修飾符使用 protected ，表示只有繼承 ViewModelBase 的子類別可以存取
     * virtual 關鍵字表示該方法可以被子類別覆寫，增加使用彈性
     * 導入 Fody 套件，可以省略 OnPropertyChanged 方法的實作，也不需要在各類別屬性 setter 呼叫
     **/

    /// <summary>
    /// Base class for all view models.
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
