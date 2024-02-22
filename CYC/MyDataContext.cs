using System.ComponentModel;

namespace CYC
{
    public class MyDataContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double myValue;

        public double MyValue
        {
            get => myValue;
            set
            {
                myValue = value;
                OnPropertyChanged(nameof(MyValue));
            }
        }

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
