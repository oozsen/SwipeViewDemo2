using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SwipeViewDemo2
{
    public partial class CollectionViewPage : ContentPage
    {
        public CollectionViewPage()
        {
            InitializeComponent();

            BindingContext = new DemoViewModel("collectionview");

            MessagingCenter.Subscribe<DemoViewModel>(this, "favourite_collectionview", sender => { DisplayAlert("SwipeView", "Favourite", "Ok"); });
            MessagingCenter.Subscribe<DemoViewModel>(this, "delete_collectionview", sender => { DisplayAlert("SwipeView", "Delete", "Ok"); });
        }
    }
}
