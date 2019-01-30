using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPHelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(textbox.Text != "")
            {
                txtblock.Text = "Hello: "+ textbox.Text;
            }
            else
            {
                txtblock.Text = "Please provide your name";
            }
        }

        private void openPage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(example));
        }

        private void openOnePage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OneWay));
        }

        private void openTwoPage(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TwoWay));
        }

        private void Open_element_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Element));
        }
        
        private void openProgressiveRendering(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ProgressiveRendering));
        }

        private void Open_adaptiveUi_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdaptiveUi));
        }

        private void Open_relative_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RelativePage));
        }

        private void Open_adaptiveCode_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdaptiveCode));
        }

        private void Open_file_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(FileApp));
        }

        private void Open_db_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DatabaseConn));
        }
    }
}
