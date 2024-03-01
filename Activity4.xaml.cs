using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity4 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }
        public Activity4()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee
            {
                DisplayName = "Juan Dela Cruz",
                Position = "President",
                Image = "https://i.pinimg.com/236x/70/44/83/704483664eaf850449e625b53572c4ba.jpg"
            });

            employees.Add(new Employee
            {
                DisplayName = "John Doe",
                Position = "Vice President",
                Image = "https://i.pinimg.com/236x/70/44/83/704483664eaf850449e625b53572c4ba.jpg"
            });

            employees.Add(new Employee
            {
                DisplayName = "Peter Doe",
                Position = "Secretary",
                Image = "https://i.pinimg.com/236x/70/44/83/704483664eaf850449e625b53572c4ba.jpg"
            });

            employees.Add(new Employee
            {
                DisplayName = "Mark Cruz",
                Position = "Supervisor",
                Image = "https://i.pinimg.com/236x/70/44/83/704483664eaf850449e625b53572c4ba.jpg"
            });

            employees.Add(new Employee
            {
                DisplayName = "Juan Dela Cruz",
                Position = "Manager",
                Image = "https://i.pinimg.com/236x/70/44/83/704483664eaf850449e625b53572c4ba.jpg"
            });
        }
        private void DisplayMessage(object sender, ToggledEventArgs e)
        {
            SwitchCell switchCell = new SwitchCell();
            bool isToggledOn = e.Value;

            if (isToggledOn)
            {
                DisplayAlert("Switch Toggled On", 
                             "The Switch is now turned on!", "OK");
            }
            else
            {
                DisplayAlert("Switch Toggled OFF", "The Switch is now turned off!", "Ok");
            }

        }
    }
}