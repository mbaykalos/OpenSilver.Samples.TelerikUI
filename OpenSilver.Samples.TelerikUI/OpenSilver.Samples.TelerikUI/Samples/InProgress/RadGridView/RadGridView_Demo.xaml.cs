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
    public partial class RadGridView_Demo : UserControl
    {
        public RadGridView_Demo()
        {
            this.InitializeComponent();
        }

        private void ButtonViewSource_Click(object sender, RoutedEventArgs e)
        {
            ViewSourceButtonHelper.ViewSource(new List<ViewSourceButtonInfo>()
            {
                new ViewSourceButtonInfo()
                {
                    TabHeader = "RadGridView_Demo.xaml",
                    FilePathOnGitHub = "github.com/OpenSilver/OpenSilver.Samples.TelerikUI/blob/master/OpenSilver.Samples.TelerikUI/OpenSilver.Samples.TelerikUI/Samples/InProgress/RadGridView/RadGridView_Demo.xaml"
                },
                new ViewSourceButtonInfo()
                {
                     TabHeader = "RadGridView_Demo.xaml.cs",
                     FilePathOnGitHub = "github.com/OpenSilver/OpenSilver.Samples.TelerikUI/blob/master/OpenSilver.Samples.TelerikUI/OpenSilver.Samples.TelerikUI/Samples/InProgress/RadGridView/RadGridView_Demo.xaml.cs"
                },
                new ViewSourceButtonInfo()
                {
                     TabHeader = "Planets.cs",
                     FilePathOnGitHub = "github.com/OpenSilver/OpenSilver.Samples.TelerikUI/blob/master/OpenSilver.Samples.TelerikUI/OpenSilver.Samples.TelerikUI/Samples/InProgress/RadGridView/Planets.cs"
                }
            });
        }
    }
}
