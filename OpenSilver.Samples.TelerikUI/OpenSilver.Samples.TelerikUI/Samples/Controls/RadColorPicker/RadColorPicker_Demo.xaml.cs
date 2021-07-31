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
    public partial class RadColorPicker_Demo : UserControl
    {
        public RadColorPicker_Demo()
        {
            this.InitializeComponent();
        }

        private void ButtonViewSource_Click(object sender, RoutedEventArgs e)
        {
            ViewSourceButtonHelper.ViewSource(new List<ViewSourceButtonInfo>()
            {
                new ViewSourceButtonInfo()
                {
                    TabHeader = "RadColorPicker_Demo.xaml",
                    FilePathOnGitHub = "github.com/OpenSilver/OpenSilver.Samples.TelerikUI/blob/master/OpenSilver.Samples.TelerikUI/OpenSilver.Samples.TelerikUI/Samples/Supported/RadColorPicker/RadColorPicker_Demo.xaml"
                },
                new ViewSourceButtonInfo()
                {
                     TabHeader = "RadColorPicker_Demo.xaml.cs",
                     FilePathOnGitHub = "github.com/OpenSilver/OpenSilver.Samples.TelerikUI/blob/master/OpenSilver.Samples.TelerikUI/OpenSilver.Samples.TelerikUI/Samples/Supported/RadColorPicker/RadColorPicker_Demo.xaml.cs"
                }
            });
        }

        private void SelectedColor_Changed(object sender, EventArgs e)
        {
            Color color = ColorPicker.SelectedColor;
            SolidColorBrush brush = new SolidColorBrush(color);
            ColorBorder.Background = brush;
        }
    }
}
