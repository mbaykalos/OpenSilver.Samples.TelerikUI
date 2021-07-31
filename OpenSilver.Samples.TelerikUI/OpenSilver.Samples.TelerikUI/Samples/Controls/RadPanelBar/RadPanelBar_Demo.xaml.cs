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
    public partial class RadPanelBar_Demo : UserControl
    {
        public RadPanelBar_Demo()
        {
            this.InitializeComponent();
        }


        private void ButtonViewSource_Click(object sender, RoutedEventArgs e)
        {
            ViewSourceButtonHelper.ViewSource(new List<ViewSourceButtonInfo>()
            {
                new ViewSourceButtonInfo()
                {
                    TabHeader = "RadContextMenu_Demo.xaml",
                    FilePathOnGitHub = "github.com/OpenSilver/OpenSilver.Samples.TelerikUI/blob/master/OpenSilver.Samples.TelerikUI/OpenSilver.Samples.TelerikUI/Samples/Broken/RadContextMenu/RadContextMenu_Demo.xaml"
                },
                new ViewSourceButtonInfo()
                {
                     TabHeader = "RadContextMenu_Demo.xaml.cs",
                     FilePathOnGitHub = "github.com/OpenSilver/OpenSilver.Samples.TelerikUI/blob/master/OpenSilver.Samples.TelerikUI/OpenSilver.Samples.TelerikUI/Samples/Broken/RadContextMenu/RadContextMenu_Demo.xaml.cs"
                }
            });
        }
    }
}
