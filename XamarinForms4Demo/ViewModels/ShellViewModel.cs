﻿using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms4Demo.ViewModels
{
    public class ShellViewModel
    {
        public ICommand ClickCommand { get; set; }
        
        public ShellViewModel()
        {
            ClickCommand = new Command(async () => {
                await Shell.Current.GoToAsync("shellpush?name=tralala", true);
            });
        }
    }
}
