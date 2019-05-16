using System.ComponentModel;
using System.Windows;
using System;

namespace TestProject
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { { Console.WriteLine(string.Format("ViewModel Property {0} has been updated", e.PropertyName)); }; };
    }
}
