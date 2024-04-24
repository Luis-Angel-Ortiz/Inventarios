using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace Inventario
{	
	public partial class ModalRecepcion:PopupPage
	{
        Entry productoTextoEntry;
        Entry precioNumericaEntry;

        public ModalRecepcion ()
		{
			InitializeComponent ();
			productoTextoEntry = productoTextoEntryXaml;
            precioNumericaEntry = precioNumericaEntryXaml;

        }

        [Obsolete]
        async void Aceptar_Clicked(System.Object sender, System.EventArgs e)
        {
			string productoTexto = productoTextoEntry.Text;
            int precioNumerica = Convert.ToInt32(precioNumericaEntry.Text);

            await PopupNavigation.PopAsync();
        }
    }
}

