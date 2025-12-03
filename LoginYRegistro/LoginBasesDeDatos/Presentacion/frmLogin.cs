using LoginBasesDeDatos.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginBasesDeDatos
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.");
                return;
            }

            ConsultasUsuario a = new ConsultasUsuario();

            // Verifica si el usuario existe
            var todosUsuarios = a.ObtenerTodosLosUsuarios();
            var usuarioEncontrado = todosUsuarios.FirstOrDefault(u => u.usuario == txtUsuario.Text.Trim());

            if (usuarioEncontrado == null)
            {
                MessageBox.Show("El usuario no existe, verifica nuevamente.");
                return;
            }

            // Verifica si la contraseña es correcta
            Usuario usuario = a.IniciarSesion(txtUsuario.Text.Trim(), txtContraseña.Text.Trim());
            if (usuario != null && usuario.id > 0)
            {
                MessageBox.Show("Inicio de Sesion exitoso");
                this.Hide();
                using (frmMenu menu = new frmMenu(usuario.usuario))
                {
                    if (menu.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                        txtContraseña.Text = "";
                        txtUsuario.Text = "";
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("La contraseña es incorrecta.");
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
