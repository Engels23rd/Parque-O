using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parque_O
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_acceder_Click(object sender, EventArgs e)
        {
            string usuario = txt_user.Text;
            string contraseña = txt_pass.Text;

            if (usuario == "Admin" && contraseña == "1234")
            {
                MessageBox.Show("Inicio de sesión exitoso como administrador.");
                Dashboard dashboardForm = new Dashboard();
                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intenta de nuevo.");
            }
        }

        private void bt_registrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opcion aun no funciona");
        }

    }
}
