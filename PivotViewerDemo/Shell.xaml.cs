using System;
using System.Windows;

namespace PivotViewerDemo
{
    public partial class Shell
    {
        public Shell()
        {
            InitializeComponent();
        }

        private void NavigatePivotButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void NavigateDummyButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("/DummyPage.xaml", UriKind.Relative));
        }
    }
}