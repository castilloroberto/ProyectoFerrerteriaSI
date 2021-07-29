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
    public partial class Login : Form
    {
        Usuarios usuarios = new Usuarios();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

            usuarios.NombreUsuario = txt_usuario.Text;
            usuarios.Clave = txt_clave.Text;
            bool res = usuarios.Loggear();


            if (res == true)
            {
                Menu menu = new Menu(usuarios);
                menu.Show();
                this.Hide();
            }
        }
    }
}