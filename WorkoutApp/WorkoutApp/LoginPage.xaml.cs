
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PancakeView;

namespace WorkoutApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.RemovePage(this);
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MasterPage());
        }
    }
}
