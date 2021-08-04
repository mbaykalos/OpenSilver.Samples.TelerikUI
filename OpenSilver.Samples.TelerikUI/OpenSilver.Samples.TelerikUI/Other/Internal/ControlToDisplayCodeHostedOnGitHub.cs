using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace OpenSilver.Samples.TelerikUI
{
    public class ControlToDisplayCodeHostedOnGitHub : ContentControl
    {
        string _filePathOnGitHub;
        string _displayedHtmlString;

        public ControlToDisplayCodeHostedOnGitHub()
        {
            this.Loaded += OnLoaded;

            VerticalContentAlignment = VerticalAlignment.Stretch;
            HorizontalContentAlignment = HorizontalAlignment.Stretch;
        }

        void OnLoaded(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(_filePathOnGitHub))
            {
                string htmlString = string.Format("<script src='https://gist-it.appspot.com/{0}?footer=no'></script>", _filePathOnGitHub);
                DisplayHtmlString(htmlString);
            }
        }

        void DisplayHtmlString(string htmlString)
        {
            var webView = new WebBrowser();
            webView.NavigateToString(htmlString);
            this.Content = webView;
            _displayedHtmlString = htmlString;
        }

        public string FilePathOnGitHub
        {
            get
            {
                return _filePathOnGitHub;
            }
            set
            {
                _filePathOnGitHub = value;

                if (this.IsLoaded)
                {
                    string htmlString = string.Format("<script src='https://gist-it.appspot.com/{0}?footer=no'></script>", FilePathOnGitHub);
                    if (htmlString != _displayedHtmlString)
                    {
                        DisplayHtmlString(htmlString);
                    }
                }
            }
        }
    }
}
