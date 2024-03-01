using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml.Diagnostics;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private async void Activity1Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity1());
        }

        private async void Activity2Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity2());
        }

        private async void Activity3Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity3());
        }

        private async void Activity4Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity4());
        }

        private async void Activity5Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity5());
        }
    }
}