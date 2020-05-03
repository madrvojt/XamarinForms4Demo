using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinForms4Demo.Models;
using XamarinForms4Demo.ViewModels;

namespace XamarinForms4Demo.Features
{
    public partial class CollectionViewPage : ContentPage
    {
        public CollectionViewPage()
        {
            InitializeComponent();
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            // await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }
        
    }
}