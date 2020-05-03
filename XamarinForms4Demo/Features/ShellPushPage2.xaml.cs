using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinForms4Demo.ViewModels;

namespace XamarinForms4Demo.Features
{
    public partial class ShellPushPage2 : ContentPage
    {
        public ShellPushPage2()
        {
            InitializeComponent();
            BindingContext = new Shell2ViewModel();
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((Shell2ViewModel)BindingContext).Appear();
        }
    }
}
