using Xamarin.Forms;
using XamarinForms4Demo.Features;

namespace XamarinForms4Demo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            
            // Routing.RegisterRoute("shellpush", typeof(ShellPushPage2));
            
            Device.SetFlags(new[] {
                 "RadioButton_Experimental",
            } );
            
            
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