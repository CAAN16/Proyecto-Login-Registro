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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            using (frmRegistro registro = new frmRegistro())
            {
                this.Hide();
                if (registro.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                    MessageBox.Show("Registro exitoso.");   
                }
                else
                {
                    MessageBox.Show("No se pudo registrar");
                    this.Show();
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            using (frmVerUsuarios verUsuarios = new frmVerUsuarios())
            {
                this.Hide();
                if(verUsuarios.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                
            }
        }
    }
}
