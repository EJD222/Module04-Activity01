using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity5 : ContentPage
    {
        public Activity5()
        {
            InitializeComponent();
        }

       void OnSubmitEntry(object sender, EventArgs e)
       {
            string entry1Text = FName.Text;
            string entry2Text = LName.Text;
            string entry3Text = MyEmail.Text;
            DisplayAlert("Entered Values", $"First Name: {entry1Text}\n" +
                            $"Last Name: {entry2Text}\n" +
                            $"Email: {entry3Text}\n" +
                            "Are you sure you want to submit?",
                            "Ok", "Cancel");
       }
    }
}