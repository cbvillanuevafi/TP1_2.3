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
        private string codigoGenerado = "";
        public frmRecuperarContrasena()
        {
            InitializeComponent();
        }

        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese un nombre de usuario.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsuario.Focus();

                return;
            }

            Usuario usuarioEncontrado = null;

            foreach (Usuario usuario in DatosSistema.Usuarios)
            {
                if (usuario.NombreUsuario == txtUsuario.Text.Trim())
                {
                    usuarioEncontrado = usuario;
                    break;
                }
            }

            if (usuarioEncontrado == null)
            {
                MessageBox.Show(
                    "El usuario no existe.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtUsuario.Focus();

                return;
            }

            Random random = new Random();

            codigoGenerado = random.Next(100000, 1000000).ToString();

            MessageBox.Show(
    "Código generado: " + codigoGenerado,
    "FEXI",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);

            txtCodigo.Enabled = true;

            btnValidarCodigo.Enabled = true;

            txtCodigo.Focus();
        }

        private void btnValidarCodigo_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese el código recibido.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCodigo.Focus();

                return;
            }

            if (txtCodigo.Text != codigoGenerado)
            {
                MessageBox.Show(
                    "El código es incorrecto.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtCodigo.Focus();

                return;
            }

            txtNuevaContrasena.Enabled = true;

            txtConfirmarContrasena.Enabled = true;

            btnGuardar.Enabled = true;

            txtNuevaContrasena.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNuevaContrasena.Text.Trim() == "" ||
    txtConfirmarContrasena.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Complete ambas contraseñas.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (txtNuevaContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show(
                    "Las contraseñas no coinciden.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtConfirmarContrasena.Focus();

                return;
            }

            Usuario usuarioEncontrado = null;

            foreach (Usuario usuario in DatosSistema.Usuarios)
            {
                if (usuario.NombreUsuario == txtUsuario.Text.Trim())
                {
                    usuarioEncontrado = usuario;
                    break;
                }
            }

            usuarioEncontrado.Contrasena = txtNuevaContrasena.Text.Trim();

            usuarioEncontrado.PrimerIngreso = false;

            MessageBox.Show(
    "La contraseña fue actualizada correctamente.",
    "FEXI",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);

            frmLogin login = new frmLogin();

            login.Show();

            this.Close();
        }
    }
}
