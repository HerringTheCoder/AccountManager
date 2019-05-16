using System;
using System.ComponentModel;

namespace TestProject
{
    class Account : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { Console.WriteLine(string.Format("Model Property {0} has been updated", e.PropertyName)); };
        public int Value { get; set; }
        public int ID { get; set; }

        public Account(int ID, int value)
        {   
            this.Value = value;
            this.ID = ID;
        }
    }
}
