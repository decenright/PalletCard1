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

namespace PalletCard
{
    /// <summary>
    /// Interaction logic for Action.xaml
    /// </summary>
    public partial class Action : Page
    {
        public Action()
        {
            InitializeComponent();
        }

        private void btnAction2_Click(object sender, RoutedEventArgs e)
        {
            Section s = new Section();
            this.NavigationService.Navigate(s);
        }
    }
}
