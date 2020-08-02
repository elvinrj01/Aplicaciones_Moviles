using name_app.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace name_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SecondApp();
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
