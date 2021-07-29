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

namespace ProyectoFerrerteriaSI
{
    public partial class Ventas : UserControl
    {
        Productos productos = new Productos();
        Guid codventa;
        Ventas Venta = new Ventas();

        public Ventas()
        {
            InitializeComponent();
            CargarProductos();
            limpiarventas();
         
        }

        private void limpiarventas()
        {
            codventa = Guid.NewGuid();

        }

        private void CargarProductos()
        {
            
            dgvprod.DataSource = productos.GetProdutos();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            DetalleVentas dtv = new DetalleVentas() {
                CodProd = getcell(0),
                Cantidad = int.Parse(txtcantprod.Text),
                Precio = decimal.Parse(txtprecio.Text),
                CodVenta = codventa

        };
            //llamar a la clase de ventas

        }

        private void dgvprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //para cualquier tipo de datos el dynamic
        private dynamic getcell(int cell)//celda
        {
            var index = dgvprod.CurrentRow.Index;
            return dgvprod.Rows[index].Cells[cell].Value;
        }

        private void dgvprod_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            decimal cell = getcell(2);//esto es como mostrar la columna que le estas asignando
            txtprecio.Text = string.Format("{0}",cell) ;//insertando un valor dentro de esa expresion
        }
    }
}
