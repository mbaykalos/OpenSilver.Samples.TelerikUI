using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace OpenSilver.Samples.TelerikUI
{
    static class ViewSourceButtonHelper
    {
        public static void ViewSource(List<ViewSourceButtonInfo> sourcePaths)
        {
            if (sourcePaths.Count > 0)
            {
                var tabControl = new TabControl();

                foreach (ViewSourceButtonInfo viewSourceButtonInfo in sourcePaths)
                {
                    var tabItem = new TabItem()
                    {
                        Header = viewSourceButtonInfo.TabHeader,
                        Content = new ControlToDisplayCodeHostedOnGitHub()
                        {
                            FilePathOnGitHub = viewSourceButtonInfo.FilePathOnGitHub
                        }
                    };

                    tabControl.Items.Add(tabItem);
                }

                ((TabItem)tabControl.Items[0]).IsSelected = true;

                MainPage.Current.ViewSourceCode(tabControl);
            }
        }
    }
}
