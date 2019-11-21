using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace XamarinForms4Demo.ViewModels
{
    [QueryProperty("Name", "name")]
    public class Shell2ViewModel
    {
        public string Name { get; set; }


        public Shell2ViewModel()
        {
        }


        public void Appear()
        {
            Debug.WriteLine("Read");

        }

    }
}
