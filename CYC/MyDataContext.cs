using System.ComponentModel;

namespace CYC
{
    public class MyDataContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public double MyValue { get; set; }
    }
}