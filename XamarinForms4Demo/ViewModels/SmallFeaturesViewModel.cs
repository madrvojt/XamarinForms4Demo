using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms4Demo.ViewModels
{
    public class SmallFeaturesViewModel
    {

        public ICommand CLickCommand { get; set; }

     
        public SmallFeaturesViewModel()
        {

            CLickCommand = new Command(async () => {

                await Device.InvokeOnMainThreadAsync(() => {


                });


            });
        }
    }
}
