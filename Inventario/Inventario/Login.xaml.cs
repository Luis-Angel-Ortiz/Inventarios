using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Inventario
{	
	public partial class Login : ContentPage
	{
        public Login ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if(txtUsername.Text=="admin" && txtPassword.Text == "123")
            {
                Navigation.PushAsync(new Dashboard());
            }
            else
            {
                DisplayAlert("Alert", "Username or Password is Incorrect", "OK");
            }
        }

        private void DisplayAlert(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }
    }
}

