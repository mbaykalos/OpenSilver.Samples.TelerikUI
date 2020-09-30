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
using Telerik.Windows.Controls;

namespace OpenSilver.Samples.TelerikUI
{
    public partial class RadTransitionControl_Demo : UserControl
    {
        public RadTransitionControl_Demo()
        {
            this.InitializeComponent();
        }

        private void ButtonViewSource_Click(object sender, RoutedEventArgs e)
        {
            ViewSourceButtonHelper.ViewSource(new List<ViewSourceButtonInfo>()
            {
                new ViewSourceButtonInfo()
                {
                    TabHeader = "RadTransitionControl_Demo.xaml",
                    FilePathOnGitHub = "github.com/OpenSilver/OpenSilver.Samples.TelerikUI/blob/master/OpenSilver.Samples.TelerikUI/OpenSilver.Samples.TelerikUI/Samples/InProgress/RadTransitionControl/RadTransitionControl_Demo.xaml"
                },
                new ViewSourceButtonInfo()
                {
                     TabHeader = "RadTransitionControl_Demo.xaml.cs",
                     FilePathOnGitHub = "github.com/OpenSilver/OpenSilver.Samples.TelerikUI/blob/master/OpenSilver.Samples.TelerikUI/OpenSilver.Samples.TelerikUI/Samples/InProgress/RadTransitionControl/RadTransitionControl_Demo.xaml.cs"
                }
            });
        }

        bool isButtonInVisualTree = true;
        RadButton myRadButton;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonInVisualTree)
            {
                myRadButton = MyRadButton;
                radTransitionControl.Content = null;
                isButtonInVisualTree = false;
            }
            else
            {
                radTransitionControl.Content = myRadButton;
                isButtonInVisualTree = true;
            }
        }
    }
}
