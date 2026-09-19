namespace TP1_2._3
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            
            txtUsuario.Focus();

            txtUsuario.Clear();
            txtContrasena.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese un usuario.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsuario.Focus();

                return;
            }

            if (txtContrasena.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese una contraseña.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtContrasena.Focus();

                return;
            }

            Usuario usuarioEncontrado =
                AccesoDatos.ObtenerUsuarioPorCredenciales(
                    txtUsuario.Text,
                    txtContrasena.Text);

            if (usuarioEncontrado == null)
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (usuarioEncontrado.PrimerIngreso)
            {
                frmCambioContrasena cambio = new frmCambioContrasena(usuarioEncontrado);
                cambio.ShowDialog();
            }

            //        MessageBox.Show(
            //"Inicio de sesión correcto.",
            //"FEXI",
            //MessageBoxButtons.OK,
            //MessageBoxIcon.Information);

            if (usuarioEncontrado.TipoUsuario == "Administrador")
            {
                frmPrincipalAdmin admin =
    new frmPrincipalAdmin(usuarioEncontrado);

                admin.Show();

                this.Hide();
            }

            if (usuarioEncontrado.TipoUsuario == "Empleado")
            {
                frmPrincipalGeneral general =
    new frmPrincipalGeneral(usuarioEncontrado);

                general.Show();

                this.Hide();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.PasswordChar == '*')
            {
                txtContrasena.PasswordChar = '\0';

                btnMostrar.Text = "Ocultar";
            }
            else
            {
                txtContrasena.PasswordChar = '*';

                btnMostrar.Text = "Ver";
            }
        }

        private void lnkRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperarContrasena recuperar =
        new frmRecuperarContrasena();

            recuperar.ShowDialog();
        }
    }
}
