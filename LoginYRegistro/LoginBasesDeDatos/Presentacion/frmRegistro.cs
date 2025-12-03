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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text) || string.IsNullOrWhiteSpace(txtConfirmarContra.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            if(dtpFechaNacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser en el futuro.");
                return;
            }
            if(txtContraseña.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.");
                return;
            }

            if (txtContraseña.Text != txtConfirmarContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }
            Usuario usuario = new Usuario();
            usuario.nombre=txtNombre.Text.Trim();
            usuario.apellidos=txtApellidos.Text.Trim();
            usuario.usuario=txtUsuario.Text.Trim();
            usuario.correo=txtCorreo.Text.Trim();
            usuario.telefono=txtTelefono.Text.Trim();
            usuario.password=txtContraseña.Text.Trim();
            usuario.fechaNacimiento = dtpFechaNacimiento.Value;
            ConsultasUsuario a = new ConsultasUsuario();

            if (a.AgregarUsuario(usuario))
            {
                this.DialogResult = DialogResult.OK;
            }


        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (txtTelefono.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            string expression = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text, expression))
            {
                MessageBox.Show("El correo electrónico no es válido.");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            string expression = @"^\d{10}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtTelefono.Text, expression))
            {
                MessageBox.Show("El número de teléfono no es válido. Debe contener 10 dígitos.");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
