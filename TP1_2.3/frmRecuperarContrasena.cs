using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP1_2._3
{
    public partial class frmRecuperarContrasena : Form
    {
        public frmRecuperarContrasena()
        {
            InitializeComponent();
        }

        private void frmRecuperarContrasena_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreusuario.Text)) 
            {
                MessageBox.Show("Para Guardar debe Ingresar el Nombre de usuario registrado");
                txtNombreusuario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtCodigoenviado.Text))
            {
                MessageBox.Show("Para Guardar debe Ingresar el Codigo que recibio");
                txtCodigoenviado.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtContraseñanueva.Text))
            {
                MessageBox.Show("Para Guardar ingrese su nueva contraseña");
                txtContraseñanueva.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtConfirmarcontraseña.Text))
            {
                MessageBox.Show("Para Guardar ingrese la confirmacion de su contraseña");
                txtConfirmarcontraseña.Focus();
                return;
            }

        }
    }
}
