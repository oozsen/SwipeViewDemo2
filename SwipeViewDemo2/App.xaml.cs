﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwipeViewDemo2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new TabbedPage()
            {
                Children =
                {
                    new NavigationPage(new ListViewPage()) { Title = "ListView" },
                    new NavigationPage(new CollectionViewPage()) { Title = "CollectionView" },
                    //new NavigationPage(new ProgrammaticalSwipeView()) { Title = "Programmatically" },
                    //new NavigationPage(new PageSwipe()) { Title = "Page swipe" }
                }
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
