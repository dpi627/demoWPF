using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoWPF
{
    public class MyDataContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        //public void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        //private double _myValue;
        //public double MyValue
        //{
        //    get => _myValue;
        //    set
        //    {
        //        _myValue = value;
        //        OnPropertyChanged(nameof(MyValue));
        //    }
        //}
        public double MyValue { get; set; }
    }
}
