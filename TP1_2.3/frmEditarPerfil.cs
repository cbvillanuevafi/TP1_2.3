using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP1_2._3
{
    public partial class frmEditarPerfil : Form
    {
        private Usuario usuarioEditar;
        public frmEditarPerfil()
        {
            InitializeComponent();
        }
        public frmEditarPerfil(Usuario usuario)
        {
            InitializeComponent();

            usuarioEditar = usuario;
        }

        private void frmEditarPerfil_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Add("Femenino");
            cmbGenero.Items.Add("Masculino");
            cmbGenero.Items.Add("No binario");
            cmbGenero.Items.Add("Prefiero no decirlo");

            cmbTipoUsuario.Items.Add("Administrador");
            cmbTipoUsuario.Items.Add("General");

            if (usuarioEditar != null)
            {
                txtNombre.Text = usuarioEditar.Nombre;
                txtApellido.Text = usuarioEditar.Apellido;
                txtDni.Text = usuarioEditar.Dni;
                txtTelefono.Text = usuarioEditar.Telefono;
                txtEmail.Text = usuarioEditar.Email;

                cmbGenero.Text = usuarioEditar.Genero;
                cmbTipoUsuario.Text = usuarioEditar.TipoUsuario;

                if (usuarioEditar.FechaNacimiento >= dtpFechaNacimiento.MinDate)
                {
                    dtpFechaNacimiento.Value =
                        usuarioEditar.FechaNacimiento;
                }
            }

            txtDni.Enabled = false;
            cmbTipoUsuario.Enabled = false;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese un nombre.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();

                return;
            }

            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese un apellido.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtApellido.Focus();

                return;
            }

            if (txtTelefono.Text.Length != 10)
            {
                MessageBox.Show(
                    "El teléfono debe tener 10 dígitos.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTelefono.Focus();

                return;
            }

            if (!txtEmail.Text.Contains("@") ||
    !txtEmail.Text.Contains("."))
            {
                MessageBox.Show(
                    "Ingrese un email válido.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();

                return;
            }

            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                MessageBox.Show(
                    "La fecha de nacimiento no puede ser futura.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            usuarioEditar.Nombre = txtNombre.Text;
            usuarioEditar.Apellido = txtApellido.Text;
            usuarioEditar.Telefono = txtTelefono.Text;
            usuarioEditar.Email = txtEmail.Text;
            usuarioEditar.Genero = cmbGenero.Text;
            usuarioEditar.FechaNacimiento = dtpFechaNacimiento.Value;

            MessageBox.Show(
    "Perfil actualizado correctamente.",
    "FEXI",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);

            this.Close();
        }
    }
}
