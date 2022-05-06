using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace amazon_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Device.SetFlags(new[] { "Amazon_Grad" });
            MainPage = new AppShell();
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
