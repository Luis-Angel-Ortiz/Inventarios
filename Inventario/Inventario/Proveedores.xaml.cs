using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Inventario
{	
	public partial class Proveedores : ContentPage
	{	
		public Proveedores ()
		{
			InitializeComponent ();
            // Inicializa la lista de productos
            List<string> productos = new List<string>
            {
                "Sabritas",
                "Refrescos",
                "Donas",
                "Galletas"
                // Puedes agregar más productos aquí según sea necesario
            };

            // Agrega los productos al Picker de Productos
            foreach (string producto in productos)
            {
                ProductosPicker.Items.Add(producto);
            }
        }

        private void CategoriaPicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var selectedCategoria = CategoriaPicker.SelectedItem?.ToString();
            if (selectedCategoria == "Materia Prima")
            {
                // Aquí puedes agregar opciones de productos de materia prima al Picker de Productos
            }
            else if (selectedCategoria == "Productos Terminados")
            {
                // Aquí puedes agregar opciones de productos terminados al Picker de Productos
            }
            else if (selectedCategoria == "Servicios")
            {
                // Aquí puedes agregar opciones de servicios al Picker de Productos
            }

            ProductosPicker.IsEnabled = true;
        }

        private void ProductosPicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var selectedProductos = ProductosPicker.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedProductos))
            {
                SeleccionLabel.Text += selectedProductos + ", ";
            }
        }
    }
}

