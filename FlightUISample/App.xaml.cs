using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlightUISample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.FlightPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
