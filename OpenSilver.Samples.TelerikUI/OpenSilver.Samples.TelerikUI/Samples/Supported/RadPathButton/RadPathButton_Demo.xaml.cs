using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace OpenSilver.Samples.TelerikUI
{
    public partial class RadPathButton_Demo : UserControl
    {
        public RadPathButton_Demo()
        {
            this.InitializeComponent();
        }

        private void RadPathButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You pressed the button");
        }

        private void ButtonViewSource_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
