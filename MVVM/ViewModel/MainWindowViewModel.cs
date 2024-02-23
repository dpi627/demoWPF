﻿using MVVM.Command;
using System.Windows.Input;

namespace MVVM.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            ChangeMessage = new ChangeMessageCommand(this);
        }
        public string Name { get; set; } = "Unknow";
        public string Message { get; set; } = "Hello, World!";
        public decimal MyValue { get; set; }
        public required ICommand ChangeMessage { get; set; }
    }
}
