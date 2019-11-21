using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms4Demo.Features;
using XamarinForms4Demo.Services;
using XamarinForms4Demo.Views;

namespace XamarinForms4Demo
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            Routing.RegisterRoute("shellpush", typeof(ShellPushPage2));

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
