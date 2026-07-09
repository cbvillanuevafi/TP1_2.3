using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP1_2._3
{
    public partial class frmPrincipalGeneral : Form
    {
        private Usuario usuarioLogueado;
        public frmPrincipalGeneral()
        {
            InitializeComponent();
        }

        public frmPrincipalGeneral(Usuario usuario)
        {
            InitializeComponent();

            usuarioLogueado = usuario;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLogin login =
        new frmLogin();

            login.Show();

            this.Close();
        }

        private void frmPrincipalGeneral_Load(object sender, EventArgs e)
        {
            if (usuarioLogueado != null)
            {
                lblBienvenidaGeneral.Text =
                    "Bienvenido, " +
                    usuarioLogueado.Nombre + " " +
                    usuarioLogueado.Apellido;
            }
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            frmEditarPerfil editar =
        new frmEditarPerfil(usuarioLogueado);

            editar.ShowDialog();
        }
    }
}