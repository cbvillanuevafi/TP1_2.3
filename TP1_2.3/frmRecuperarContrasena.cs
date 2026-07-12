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
        //variable el cual Resultado de tipo DialogResult la cual capta la respuesta que dio el usuario con
        //respecto a los botones del Messagabox
        DialogResult Resultado;

        public frmRecuperarContrasena()
        {
            InitializeComponent();
        }

        //Evento que pregunta si desea verdaderamente salir o no
        private void frmRecuperarContrasena_FormClosing(object sender, FormClosingEventArgs e)
        {
            Resultado = MessageBox.Show("¿Esta seguro que desea Cerrar?",
                "ABANDONAR EL RECUPERO DE CONTRASEÑA",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button2);
            if (Resultado == DialogResult.Cancel)
            {
                e.Cancel = true; // Cancela el cierre del formulario
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreusuario.Text)) 
            {
                MessageBox.Show("Para Guardar debe Ingresar el Nombre de usuario registrado",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtNombreusuario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtCodigoenviado.Text))
            {
                MessageBox.Show("Para Guardar debe Ingresar el Codigo que recibio",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCodigoenviado.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtContraseñanueva.Text))
            {
                MessageBox.Show("Para Guardar ingrese su nueva contraseña",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtContraseñanueva.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtConfirmarcontraseña.Text))
            {
                MessageBox.Show("Para Guardar ingrese la confirmacion de su contraseña");
                txtConfirmarcontraseña.Focus();
                return;
            }
            MessageBox.Show("Modificacion de Contraseña exitosa");

        }
    }
}
