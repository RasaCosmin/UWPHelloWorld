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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPHelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TwoWay : Page
    {
        Person per = new Person { Name = "Cosmin", Age = 27 };

        public TwoWay()
        {
            this.InitializeComponent();
            DataContext = per;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var message = per.Name + " is " + per.Age + " years old";
            txtBlock.Text = message;
        }
    }

    public class Person
    {
        private string _nameValue;
        public string Name
        {
            get { return _nameValue; }
            set { _nameValue = value; }
        }

        private double _ageValue;
        public double Age
        {
            get { return _ageValue; }
            set { _ageValue = value; }
        }
    }
}
