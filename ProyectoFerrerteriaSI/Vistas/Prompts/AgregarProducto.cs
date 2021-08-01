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
        Consultas consulta = new Consultas();
        public AgregarProducto()

        {
            InitializeComponent();
            CargarCategorias();
            CargarMarcas();
            CargarProve();

        }

        private void CargarCategorias ()
        {
            cb_categoria.DataSource = null;
            cb_categoria.DataSource = consulta.select("Select * from Categorias");
            cb_categoria.DisplayMember = "Nom_Categoria";
            cb_categoria.ValueMember = "Cod_Categoria";
        }
        private void CargarMarcas()
        {
            cb_marca.DataSource = null;
            cb_marca.DataSource = consulta.select("Select * from Marcas");
            cb_marca.DisplayMember = "Marca";
            cb_marca.ValueMember = "Cod_Marca";
        }

        private void CargarProve()
        {
            cb_proveedor.DataSource = null;
            cb_proveedor.DataSource = consulta.select("Select * from Proveedor");
            cb_proveedor.DisplayMember = "Nomb_Empresa";
            cb_proveedor.ValueMember = "Cod_Proveedor";
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos()
            {
                Producto = txt_nombreProducto.Text,
                Precio = float.Parse(txt_precio.Text),
                Stock = int.Parse(txt_stock.Text),
                CodCategoria = cb_categoria.SelectedValue.GetHashCode(),
                CodMarca = cb_marca.SelectedValue.GetHashCode(),
                CodProveedor = cb_proveedor.SelectedValue.GetHashCode()
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



        private void btn_addProveedor_Click_1(object sender, EventArgs e)
        {
            var proveedores = new AgregarProveedor();
            proveedores.ShowDialog();
            // actualia¡zar formulario para leer nuevos proveedores
        }
    }
}
