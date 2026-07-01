using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP1_2._3
{
    public partial class frmRegistrarUsuario : Form
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Add("Femenino");
            cmbGenero.Items.Add("Masculino");
            cmbGenero.Items.Add("No binario");
            cmbGenero.Items.Add("Prefiero no decirlo");

            cmbTipoUsuario.Items.Add("Administrador");
            cmbTipoUsuario.Items.Add("General");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" ||
        txtApellido.Text.Trim() == "" ||
        txtDni.Text.Trim() == "" ||
        txtTelefono.Text.Trim() == "" ||
        txtEmail.Text.Trim() == "" ||
        txtDomicilio.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Complete todos los campos antes de generar los datos.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmbGenero.SelectedIndex == -1 ||
    cmbTipoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione el género y el tipo de usuario.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            foreach (char letra in txtNombre.Text.Trim())
            {
                if (!char.IsLetter(letra) && letra != ' ')
                {
                    MessageBox.Show(
                        "El nombre solo puede contener letras.",
                        "FEXI",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }
            }

            foreach (char letra in txtApellido.Text.Trim())
            {
                if (!char.IsLetter(letra) && letra != ' ')
                {
                    MessageBox.Show(
                        "El apellido solo puede contener letras.",
                        "FEXI",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtApellido.Focus();

                    return;
                }
            }

            foreach (char caracter in txtDni.Text.Trim())
            {
                if (!char.IsDigit(caracter))
                {
                    MessageBox.Show(
                        "El DNI solo puede contener números.",
                        "FEXI",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtDni.Focus();

                    return;
                }
            }

            if (txtDni.Text.Trim().Length != 8)
            {
                MessageBox.Show(
                    "El DNI debe contener exactamente 8 dígitos.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDni.Focus();

                return;
            }

            foreach (char caracter in txtTelefono.Text.Trim())
            {
                if (!char.IsDigit(caracter))
                {
                    MessageBox.Show(
                        "El teléfono solo puede contener números.",
                        "FEXI",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtTelefono.Focus();

                    return;
                }
            }

            if (txtTelefono.Text.Trim().Length != 10)
            {
                MessageBox.Show(
                    "El teléfono debe contener exactamente 10 dígitos.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTelefono.Focus();

                return;
            }

            if (!txtEmail.Text.Trim().Contains("@") ||
    !txtEmail.Text.Trim().Contains("."))
            {
                MessageBox.Show(
                    "Ingrese un e-mail válido.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();

                return;
            }

            DateTime fechaActual = DateTime.Today;

            int edad = fechaActual.Year - dtpFechaNacimiento.Value.Year;

            if (dtpFechaNacimiento.Value.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            if (edad < 18)
            {
                MessageBox.Show(
                    "El usuario debe ser mayor de 18 años.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dtpFechaNacimiento.Focus();

                return;
            }

            string usuarioGenerado =
    txtNombre.Text.Trim().Substring(0, 1).ToLower() +
    txtApellido.Text.Trim().ToLower() +
    txtDni.Text.Trim().Substring(5);

            string usuarioFinal = usuarioGenerado;

            int contador = 2;

            foreach (Usuario usuario in DatosSistema.Usuarios)
            {
                if (usuario.NombreUsuario == usuarioFinal)
                {
                    usuarioFinal = usuarioGenerado + "_" + contador;
                    contador++;
                }
            }

            txtUsuarioGenerado.Text = usuarioFinal;

            string contrasenaGenerada =
    "Fx" +
    txtDni.Text.Trim().Substring(2);

            txtContrasenaGenerada.Text = contrasenaGenerada;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioGenerado.Text == "" ||
    txtContrasenaGenerada.Text == "")
            {
                MessageBox.Show(
                    "Primero debe generar el usuario y la contraseña.",
                    "FEXI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            foreach (Usuario usuario in DatosSistema.Usuarios)
            {
                if (usuario.NombreUsuario == txtUsuarioGenerado.Text)
                {
                    MessageBox.Show(
                        "Ese nombre de usuario ya existe.",
                        "FEXI",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            foreach (Usuario usuario in DatosSistema.Usuarios)
            {
                if (usuario.Dni == txtDni.Text.Trim())
                {
                    MessageBox.Show(
                        "Ya existe un usuario registrado con ese DNI.",
                        "FEXI",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtDni.Focus();

                    return;
                }
            }

            Usuario nuevoUsuario = new Usuario();

            nuevoUsuario.Nombre = txtNombre.Text.Trim();
            nuevoUsuario.Apellido = txtApellido.Text.Trim();
            nuevoUsuario.Dni = txtDni.Text.Trim();
            nuevoUsuario.Telefono = txtTelefono.Text.Trim();
            nuevoUsuario.Email = txtEmail.Text.Trim();
            nuevoUsuario.Domicilio = txtDomicilio.Text.Trim();
            nuevoUsuario.Genero = cmbGenero.Text;
            nuevoUsuario.FechaNacimiento = dtpFechaNacimiento.Value;
            nuevoUsuario.NombreUsuario = txtUsuarioGenerado.Text;
            nuevoUsuario.Contrasena = txtContrasenaGenerada.Text;
            nuevoUsuario.TipoUsuario = cmbTipoUsuario.Text;
            nuevoUsuario.PrimerIngreso = true;

            DatosSistema.Usuarios.Add(nuevoUsuario);

            MessageBox.Show(
    "Usuario registrado correctamente.\n\n" +
    "Se generaron las siguientes credenciales:\n\n" +
    "Usuario: " + nuevoUsuario.NombreUsuario +
    "\nContraseña: " + nuevoUsuario.Contrasena,
    "FEXI",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);

            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDomicilio.Clear();

            cmbGenero.SelectedIndex = -1;
            cmbTipoUsuario.SelectedIndex = -1;

            dtpFechaNacimiento.Value = DateTime.Today;

            txtUsuarioGenerado.Clear();
            txtContrasenaGenerada.Clear();

            txtNombre.Focus();
        }
    }
}
