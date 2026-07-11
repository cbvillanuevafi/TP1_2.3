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

            if (!DatosSistema.DatosInicializados)
            {
                DatosSistema.Usuarios.Add(
                    new Usuario()
                    {
                        Nombre = "Administrador",
                        Apellido = "Sistema",
                        Dni = "12345678",
                        Telefono = "1123456789",
                        Email = "admin@fexi.com",
                        Genero = "Masculino",
                        FechaNacimiento = new DateTime(1990, 5, 20),
                        NombreUsuario = "admin001",
                        Contrasena = "admin123",
                        TipoUsuario = "Administrador",
                        PrimerIngreso = true
                    });

                DatosSistema.Usuarios.Add(
                    new Usuario()
                    {
                        Nombre = "Juan",
                        Apellido = "Perez",
                        Dni = "30123456",
                        Telefono = "1198765432",
                        Email = "juan@gmail.com",
                        Genero = "Masculino",
                        FechaNacimiento = new DateTime(1998, 8, 15),
                        NombreUsuario = "empleado001",
                        Contrasena = "1234",
                        TipoUsuario = "Empleado",
                        PrimerIngreso = true
                    });

                DatosSistema.DatosInicializados = true;
            }
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

            Usuario usuarioEncontrado = null;

            foreach (Usuario usuario in DatosSistema.Usuarios)
            {
                if (usuario.NombreUsuario == txtUsuario.Text
                    && usuario.Contrasena == txtContrasena.Text)
                {
                    usuarioEncontrado = usuario;
                    break;
                }
            }

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
            MessageBox.Show(
                "Función no disponible.",
                "Atención",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
