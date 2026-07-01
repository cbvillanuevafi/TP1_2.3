using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP1_2._3
{
    public partial class frmCambioContrasena : Form
    {

        private Usuario usuarioActual;
        public frmCambioContrasena()
        {
            InitializeComponent();
        }

        public frmCambioContrasena(Usuario usuario)
        {
            InitializeComponent();

            usuarioActual = usuario;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNuevaContrasena.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese una nueva contraseña.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNuevaContrasena.Focus();

                return;
            }

            if (txtConfirmarContrasena.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Confirme la contraseña.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtConfirmarContrasena.Focus();

                return;
            }

            if (txtNuevaContrasena.Text.Length < 8)
            {
                MessageBox.Show(
                    "La contraseña debe tener al menos 8 caracteres.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (txtNuevaContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show(
                    "Las contraseñas no coinciden.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            usuarioActual.Contrasena =
    txtNuevaContrasena.Text;

            usuarioActual.PrimerIngreso = false;

            MessageBox.Show(
    "Contraseña actualizada correctamente.",
    "FEXI",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);

            frmPrincipalGeneral general =
    new frmPrincipalGeneral(usuarioActual);

            general.Show();

            this.Close();
        }
    }
}