using System;
using System.ComponentModel;

namespace TestProject
{
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { Console.WriteLine(string.Format("Model Property {0} has been updated", e.PropertyName)); };
        public string Login { get; protected set; }
        public string Password { get; protected set; }
        public Boolean ElevatedPrivileges { get; protected set;}

        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
            ElevatedPrivileges = false;
        }
    }
}
