using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinForms4Demo.ViewModels;

namespace XamarinForms4Demo.Features
{
    public partial class ShellPushPage1 : ContentPage
    {
        public ShellPushPage1()
        {
            InitializeComponent();
            BindingContext = new ShellViewModel();
        }
    }
}
