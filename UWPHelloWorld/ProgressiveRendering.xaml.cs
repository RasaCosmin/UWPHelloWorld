using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public sealed partial class ProgressiveRendering : Page
    {
        public ProgressiveRendering()
        {
            this.InitializeComponent();
            DataContext = EmployeeS.GetEmployees();
        }
    }

    public class EmployeeS : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        public string Name
        {
            get { return name; }
            set {
                name = value;
                OnPropertyChanged();
            }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }

        public static EmployeeS GetEmployee()
        {
            return new EmployeeS()
            {
                Name = "Cosmin",
                Title = "Developer"
            };
        }

        public static ObservableCollection<EmployeeS> GetEmployees()
        {
            var employees = new ObservableCollection<EmployeeS>();

            employees.Add(new EmployeeS() { Name = "Ali", Title = "Developer" });
            employees.Add(new EmployeeS() { Name = "Ahmed", Title = "Programmer" });
            employees.Add(new EmployeeS() { Name = "Amjad", Title = "Desiner" });
            employees.Add(new EmployeeS() { Name = "Waqas", Title = "Programmer" });
            employees.Add(new EmployeeS() { Name = "Bilal", Title = "Engineer" });
            employees.Add(new EmployeeS() { Name = "Waqar", Title = "Manager" });

            return employees;
        }
    }
}
