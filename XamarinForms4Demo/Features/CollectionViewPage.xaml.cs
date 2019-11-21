using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinForms4Demo.Models;
using XamarinForms4Demo.ViewModels;

namespace XamarinForms4Demo.Features
{
    public partial class CollectionViewPage : ContentPage
    {
        ItemsViewModel viewModel;
        public CollectionViewPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();

        }
        
            async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
            {
                var item = args.SelectedItem as Item;
                if (item == null)
                    return;

                // await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

                // Manually deselect item.
                ItemsListView.SelectedItem = null;
            }

          
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    
    }
}
