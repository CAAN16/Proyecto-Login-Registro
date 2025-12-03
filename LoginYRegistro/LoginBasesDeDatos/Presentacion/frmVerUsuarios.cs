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
    public partial class frmVerUsuarios : Form
    {
        public frmVerUsuarios()
        {
            InitializeComponent();
        }

        private void frmVerUsuarios_Load(object sender, EventArgs e)
        {
            ConsultasUsuario a = new ConsultasUsuario();

            dgvUsuarios.DataSource = a.ObtenerTodosLosUsuarios();
            if (dgvUsuarios.Columns.Count > 0)
            {
                dgvUsuarios.Columns["password"].Visible = false;
                dgvUsuarios.Columns["id"].Visible = false;
                dgvUsuarios.Columns["nombre"].HeaderText = "Nombre";
                dgvUsuarios.Columns["apellidos"].HeaderText = "Apellidos";
                dgvUsuarios.Columns["usuario"].HeaderText = "Usuario";
                dgvUsuarios.Columns["correo"].HeaderText = "Correo";
                dgvUsuarios.Columns["telefono"].HeaderText = "Teléfono";
                dgvUsuarios.Columns["fechaNacimiento"].HeaderText = "Fecha de Nacimiento";
            }

            // Personalización de colores
            dgvUsuarios.GridColor = Color.FromArgb(232, 245, 255);

            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 101, 187);
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 101, 187);
            dgvUsuarios.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            dgvUsuarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 101, 187);
            dgvUsuarios.DefaultCellStyle.SelectionForeColor = Color.White;

            // Personalización para filas alternas
            dgvUsuarios.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(184, 224, 255);
            dgvUsuarios.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dgvUsuarios.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(184, 224, 255);
            dgvUsuarios.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
