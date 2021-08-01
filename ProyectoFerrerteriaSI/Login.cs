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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void chbx_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_pass.Checked)
            {
                txt_clave.PasswordChar = '\0';
            }
            else
            {
                txt_clave.PasswordChar = '*';

            }
        }
    }
}