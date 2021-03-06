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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = App.StaticViewModel;       
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow MyLoginWindow = new LoginWindow();
            this.Visibility = Visibility.Collapsed;
            MyLoginWindow.ShowDialog();
            this.Visibility = Visibility.Visible;

        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            AccountWindow MyAccountWindow = new AccountWindow();
            this.Visibility = Visibility.Collapsed;
            MyAccountWindow.ShowDialog();
            this.Visibility = Visibility.Visible;

        }
    }
}
