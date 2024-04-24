using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace Inventario
{	
	public partial class Entrega : ContentPage
	{	
		public Entrega ()
		{
			InitializeComponent ();
		}

        [Obsolete]
        async void AgregarButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.PushAsync(new ModalRecepcion(), true);
        }
    }
}

