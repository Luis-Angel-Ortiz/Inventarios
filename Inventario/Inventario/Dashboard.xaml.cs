using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Inventario
{	
	public partial class Dashboard : ContentPage
	{	
		public Dashboard ()
		{
			InitializeComponent();
			
		}
        
        private async void Salir_Clicked(System.Object sender, System.EventArgs e)
        {
        
            await Navigation.PushAsync(new Login());
        }

         async void Inventarios_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Inventarios());
        }

        async void Factura_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Factura());
        }        

        async void Reporte_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Reporte());
        }        

        async void Entrega_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Entrega());
        }

        async void Proveedores_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Proveedores());
        }
    }
    
}

