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

namespace additional_window
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    [Obsolete]
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            // this.Hide();
            //window1.Show(); // немодальное 
            if (window1.ShowDialog() == true)
                MessageBox.Show("Good!");
            this.Show();
        }
    }
}
