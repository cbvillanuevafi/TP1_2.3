using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP1_2._3
{
    public partial class frmPrincipalAdmin : Form
    {
        private Usuario usuarioLogueado;
        public frmPrincipalAdmin()
        {
            InitializeComponent();
        }
        public frmPrincipalAdmin(Usuario usuario)
        {
            InitializeComponent();

            usuarioLogueado = usuario;
        }

        private void frmPrincipalAdmin_Load(object sender, EventArgs e)
        {
            if (usuarioLogueado != null)
            {
                lblUsuario.Text =
                    "Bienvenido, " +
                    usuarioLogueado.Nombre + " " +
                    usuarioLogueado.Apellido;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLogin login =
        new frmLogin();

            login.Show();

            this.Close();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuario registrarUsuario =
    new frmRegistrarUsuario();

            registrarUsuario.ShowDialog();
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            frmEditarPerfil editar =
    new frmEditarPerfil(usuarioLogueado);

            editar.ShowDialog();
        }
    }
}
