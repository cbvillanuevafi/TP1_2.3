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
        private bool cerrarSinConfirmar = false;
        //variable Resultado de tipo DialogResult la cual capta la respuesta que dio el usuario con
        //respecto a los botones del Messagabox
        DialogResult Resultado;
        private Usuario? usuarioRecuperado;

        public frmRecuperarContrasena()
        {
            InitializeComponent();

            btnValidarcodigo.Enabled = false;
        }

        //Evento que pregunta si desea verdaderamente salir o no
        private void frmRecuperarContrasena_FormClosing(object sender, FormClosingEventArgs e)
        {
            //1er valor "cerrarSinConfirmar" falso, no entra al if por lo tanto el evento si se ejecuta
            if (cerrarSinConfirmar)
                return;

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea cerrar?",
                "ABANDONAR EL RECUPERO DE CONTRASEÑA",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreusuario.Text))
            {
                MessageBox.Show("Para guardar debe ingresar el nombre de usuario registrado.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtNombreusuario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtCodigoenviado.Text))
            {
                MessageBox.Show("Para guardar debe ingresar el código que recibió.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCodigoenviado.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtContraseñanueva.Text))
            {
                MessageBox.Show("Para guardar ingrese su nueva contraseña.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtContraseñanueva.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtConfirmarcontraseña.Text))
            {
                MessageBox.Show("Para guardar ingrese la confirmación de su contraseña.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtConfirmarcontraseña.Focus();
                return;
            }




            // Validar longitud mínima de la contraseña
            if (txtContraseñanueva.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe ser de al menos 8 caracteres.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtContraseñanueva.Focus();
                txtContraseñanueva.SelectAll();
                return;
            }

            // Validar que ambas contraseñas sean iguales
            if (txtContraseñanueva.Text != txtConfirmarcontraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden, ambas deben ser iguales.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtConfirmarcontraseña.Focus();
                txtConfirmarcontraseña.SelectAll();
                return;
            }


            if (usuarioRecuperado == null)
            {
                MessageBox.Show("Primero validá el usuario y el código enviado.",
                    "RECUPERAR CONTRASEÑA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                UsuarioRepositorio.ActualizarContrasena(
                    usuarioRecuperado.IdUsuario,
                    txtContraseñanueva.Text,
                    false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la contraseña.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            usuarioRecuperado.Contrasena = txtContraseñanueva.Text;
            usuarioRecuperado.PrimerIngreso = false;

            MessageBox.Show("Modificación de contraseña exitosa.",
                            "RECUPERAR CONTRASEÑA",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);


            // Cerramos el formulario actual
            cerrarSinConfirmar = true;
            this.Close();


            MessageBox.Show("Debe iniciar sesión nuevamente.");

        }

        private void btnEnviarcodigo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreusuario.Text))
            {
                MessageBox.Show("Ingrese un nombre de usuario.",
                                "RECUPERAR CONTRASEÑA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtNombreusuario.Focus();
                return;
            }
            //recorremos la lista de usuarios
            Usuario? usuarioEncontrado;

            try
            {
                usuarioEncontrado = UsuarioRepositorio.BuscarPorNombreUsuario(
                    txtNombreusuario.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos.\n\n" + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (usuarioEncontrado != null)
            {
                usuarioRecuperado = usuarioEncontrado;
                MessageBox.Show("El código fue enviado al email registrado.",
                                "RECUPERAR CONTRASEÑA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                //habilitamos los campos que habiamos inabilitamos prar que el usuario no escriba nada si antes registrar usuario
                txtCodigoenviado.Enabled = true;
                txtCodigoenviado.Focus();

                //este desabilita el campo del usuario si es correcto la verificacion del mismo
                txtNombreusuario.Enabled = false;

                btnValidarcodigo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Usuario inexistente en el sistema.",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        //CREAMOS EL EVENTO DEL Boton Validar codigo
        private void btnValidarcodigo_Click(object sender, EventArgs e)
        {
            //Si al precionar el boton el campo txtCodigoenviado esta vacio , mensaje de error
            if (string.IsNullOrWhiteSpace(txtCodigoenviado.Text))
            {
                MessageBox.Show("Ingrese el código de verificación.",
                                "RECUPERAR CONTRASEÑA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                //hacemos focus ahi
                txtCodigoenviado.Focus();
                return;
            }
            //Evaluamos mensaje = es correcto 
            if (txtCodigoenviado.Text == "1234")
            {
                MessageBox.Show("Código verificado correctamente.",
                                "RECUPERAR CONTRASEÑA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Habilitamos las contraseñas
                txtContraseñanueva.Enabled = true;
                txtConfirmarcontraseña.Enabled = true;

                // Bloqueaamos el código para que no pueda modificarlo
                txtCodigoenviado.Enabled = false;


                txtContraseñanueva.Focus();
            }
            //De lo contrario se equivoco y le mostramos un mensaje de error
            else
            {
                MessageBox.Show("El código ingresado es incorrecto.",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtCodigoenviado.Clear();
                txtCodigoenviado.Focus();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
