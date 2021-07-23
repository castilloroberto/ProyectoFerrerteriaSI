using ProyectoFerrerteriaSI.Vistas;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            verVentas();
        }
        private void verVentas()
        {
            var ventas = new Ventas();
            main_panel.Controls.Clear();
            main_panel.Controls.Add(ventas);

        }
     

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            var invetario = new Inventario();
            main_panel.Controls.Add(invetario);
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            verVentas();
        }
    }
}
