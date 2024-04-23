using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace Inventario
{	
	public partial class modalPage:PopupPage
	{
        Entry cantidadTextoEntry;
        Entry cantidadNumericaEntry;

        public modalPage ()
		{
			InitializeComponent ();

            // Asignamos los Entry desde el archivo XAML
            cantidadTextoEntry = cantidadTextoEntryXaml;
            cantidadNumericaEntry = cantidadNumericaEntryXaml;
        }

        [Obsolete]
        async void Aceptar_Clicked(System.Object sender, System.EventArgs e)
        {
            // Obtener los valores ingresados
            string cantidadTexto = cantidadTextoEntry.Text;
            int cantidadNumerica = Convert.ToInt32(cantidadNumericaEntry.Text);

            // Aquí puedes realizar alguna acción con los valores ingresados, como enviarlos a una base de datos, procesarlos, etc.

            // Cerrar el modal
            await PopupNavigation.PopAsync();
        }
    }
}

