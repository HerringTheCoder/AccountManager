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
    /// Interaction logic for AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        AccountViewModel MyAccountViewModel = new AccountViewModel();
        public AccountWindow()
        {
            InitializeComponent();
            this.DataContext = MyAccountViewModel;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            MyAccountViewModel.Add();
            AccountComboBox.Items.Refresh();
            MessageBox.Show("New account added successfully");
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to remove selected account?", "Warning", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                MyAccountViewModel.Remove();
                MessageBox.Show("Account removed succesfully");

            }
            AccountComboBox.Items.Refresh();
            
        }
    }
}
