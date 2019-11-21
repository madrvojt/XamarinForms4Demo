using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinForms4Demo.ViewModels;

namespace XamarinForms4Demo.Features
{
    public partial class SmallFeaturesPage : ContentPage
    {
        public SmallFeaturesPage()
        {
            InitializeComponent();
            BindingContext = new SmallFeaturesViewModel();
        }
    }
}
