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
    public partial class FluidContentControl_Demo : UserControl
    {
        public FluidContentControl_Demo()
        {
            this.InitializeComponent();
        }

        bool isSmall = true;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(isSmall)
            {
                FluidContentControlContainer.Width = 500;
                FluidContentControlContainer.Height = 500;
                isSmall = false;
            }
            else
            {
                FluidContentControlContainer.Width = 70;
                FluidContentControlContainer.Height = 70;
                isSmall = false;
            }
        }
    }
}
