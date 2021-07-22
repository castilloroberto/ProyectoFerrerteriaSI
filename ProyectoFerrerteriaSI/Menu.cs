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
            var ventas = new Ventas();
            main_panel.Controls.Add(ventas);
        }
    }
}
