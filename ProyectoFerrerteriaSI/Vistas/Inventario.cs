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
    }
}
