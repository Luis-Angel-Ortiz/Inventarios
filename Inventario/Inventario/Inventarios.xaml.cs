using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace Inventario
{
    public partial class Inventarios : ContentPage
    {
        public Inventarios()
        {
            InitializeComponent();
        }
        [Obsolete]
        async void AgregarButton_Clicked(System.Object sender, System.EventArgs e)
        {
            // Mostrar el modal
            //await Navigation.PushModalAsync(new modalPage());

             await PopupNavigation.PushAsync(new modalPage(), true);
        }
    }
}

