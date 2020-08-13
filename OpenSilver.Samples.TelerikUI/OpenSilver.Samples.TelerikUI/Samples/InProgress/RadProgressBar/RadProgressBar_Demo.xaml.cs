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
    public partial class RadProgressBar_Demo : UserControl
    {
        public RadProgressBar_Demo()
        {
            this.InitializeComponent();
        }

        public void decreaseProgress_Click(object sender, RoutedEventArgs e)
        {
            //ProgressBar.Value--;
        }

        public void increaseProgress_Click(object sender, RoutedEventArgs e)
        {
            //ProgressBar.Value++;
        }

        private void ButtonViewSource_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
