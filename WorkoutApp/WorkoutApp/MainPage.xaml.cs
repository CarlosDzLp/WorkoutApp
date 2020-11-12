using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorkoutApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void ButtonClickedLogin(System.Object sender, System.EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new LoginPage());
            }
            catch(Exception ex)
            {

            }
        }
    }
}
