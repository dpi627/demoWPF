﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace demoWPF
{
    /// <summary>
    /// Interaction logic for FrameWindow.xaml
    /// </summary>
    public partial class FrameWindow : Window
    {
        public FrameWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new FramePage1());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new FramwPage2());
        }
    }
}
