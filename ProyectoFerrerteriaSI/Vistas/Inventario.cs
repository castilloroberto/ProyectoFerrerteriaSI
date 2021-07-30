using ProyectoFerrerteriaSI.Database;
using ProyectoFerrerteriaSI.Vistas.Prompts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFerrerteriaSI.Vistas
{

    public partial class Inventario : UserControl
    {
        Productos productos = new Productos();
        DataTable listaProductos;

        Consultas consulta = new Consultas(); 
        public Inventario()
        {
            InitializeComponent();
            CargarProductos();

        }
        private void CargarProductos()
        {
            listaProductos = productos.GetProdutos();
            dgv_productos.DataSource = listaProductos;

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var agregar = new AgregarProducto();
            agregar.ShowDialog();
            CargarProductos();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private dynamic getcell(int cell)
        {
            int index = dgv_productos.CurrentRow.Index;
            return dgv_productos.Rows[index].Cells[cell].Value;
        }
        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            int id = getcell(0);
            string Sql = "Update Productos set estado = 0 where Cod_Producto = {0}";

            bool res = consulta.modificacion(string.Format(Sql, id));

            if (res == true)
            {

                MessageBox.Show("Producto desactivado correctamente","Mensaje de sistema");
                CargarProductos();
            }
            else
                MessageBox.Show("No se pudo desactivar el producto", "Mensaje de sistema");
        }
    }
}
