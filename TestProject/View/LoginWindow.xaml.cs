using System;
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

namespace TestProject
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
       
        public LoginWindow()
        {   
            InitializeComponent();
            this.DataContext = App.StaticViewModel; 
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (App.StaticViewModel.CheckCredentials() == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong credentials. Try again...");
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            App.StaticViewModel.Password = passwordBox.Password;
            if (string.IsNullOrWhiteSpace(passwordBox.Password))
                LoginButton.IsEnabled = false;
            else
                LoginButton.IsEnabled = true;
        }
    }
}
