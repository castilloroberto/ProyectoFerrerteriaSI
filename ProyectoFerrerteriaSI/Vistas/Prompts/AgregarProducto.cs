using ProyectoFerrerteriaSI.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFerrerteriaSI.Vistas.Prompts
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos()
            {
                Producto = txt_nombreProducto.Text,
                Precio = float.Parse(txt_precio.Text),
                Stock = int.Parse(txt_stock.Text),
                //CodCategoria = cb_categoria.SelectedValue.GetHashCode(),
                //CodMarca = cb_marca.SelectedValue.GetHashCode(),
                //CodProveedor = cb_proveedor.SelectedValue.GetHashCode()
            };
            var res = producto.Insertar();

            if (res == true)
            {
                MessageBox.Show("Producto insertado con exito", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo insertar el producto intente de nuevo", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
    }
}
