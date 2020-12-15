using System;
using System.Collections.Generic;

using Xamarin.Forms;


namespace SwipeViewDemo2
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            BindingContext = new DemoViewModel("listview");

            MessagingCenter.Subscribe<DemoViewModel>(this, "favourite_listview", sender => { DisplayAlert("SwipeView", "Favourite", "Ok"); });
            MessagingCenter.Subscribe<DemoViewModel>(this, "delete_listview", sender => { DisplayAlert("SwipeView", "Delete", "Ok"); });
        }
    }
}
