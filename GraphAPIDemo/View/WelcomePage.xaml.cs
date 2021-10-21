using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GraphAPIDemo.View
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void OnSignIn(object sender, EventArgs e)
        {
            (App.Current.MainPage as FlyoutPage).IsPresented = true;
        }
    }
}
