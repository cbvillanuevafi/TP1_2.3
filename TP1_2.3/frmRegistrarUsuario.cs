using System;
using System.Text;

namespace TP1_2._3
{
    public partial class frmRegistrarUsuario : Form
    {
        private static readonly Dictionary<string, string[]> partidosPorProvincia =
            new Dictionary<string, string[]>
        {
            { "Buenos Aires", new[] { "La Plata", "Morón", "Lomas de Zamora", "Quilmes", "San Isidro" } },
            { "Córdoba", new[] { "Córdoba Capital", "Villa María", "Río Cuarto", "Villa Carlos Paz" } },
            { "Santa Fe", new[] { "Rosario", "Santa Fe Capital", "Rafaela", "Venado Tuerto" } },
            { "Mendoza", new[] { "Mendoza Capital", "San Rafael", "Godoy Cruz", "Las Heras" } },
            { "Tucumán", new[] { "San Miguel de Tucumán", "Concepción", "Banda del Río Sali", "Tafí Viejo" } }
        };

        private static readonly Dictionary<string, string[]> localidadesPorPartido =
            new Dictionary<string, string[]>
        {
            { "La Plata", new[] { "La Plata", "Berisso", "Ensenada" } },
            { "Morón", new[] { "Morón", "Haedo", "Castelar" } },
            { "Lomas de Zamora", new[] { "Lomas de Zamora", "Banfield", "Llavallol", "Otro" } },
            { "Quilmes", new[] { "Quilmes", "Bernal", "Don Bosco" } },
            { "San Isidro", new[] { "San Isidro", "Vicente López", "Martínez" } },
            { "Córdoba Capital", new[] { "Córdoba Capital", "Villa Carlos Paz" } },
            { "Villa María", new[] { "Villa María", "Villa Nueva" } },
            { "Río Cuarto", new[] { "Río Cuarto", "Villa General Belgrano" } },
            { "Villa Carlos Paz", new[] { "Villa Carlos Paz", "Cosquín" } },
            { "Rosario", new[] { "Rosario", "Funes", "Villa Gobernador Gálvez" } },
            { "Santa Fe Capital", new[] { "Santa Fe", "Reconquista" } },
            { "Rafaela", new[] { "Rafaela", "Sunchales" } },
            { "Venado Tuerto", new[] { "Venado Tuerto", "Villa Cañás" } },
            { "Mendoza Capital", new[] { "Mendoza", "Guaymallén" } },
            { "San Rafael", new[] { "San Rafael", "General Alvear" } },
            { "Godoy Cruz", new[] { "Godoy Cruz", "Las Heras" } },
            { "Las Heras", new[] { "Las Heras", "General San Martín" } },
            { "San Miguel de Tucumán", new[] { "San Miguel de Tucumán", "Yerba Buena" } },
            { "Concepción", new[] { "Concepción", "Bella Vista" } },
            { "Banda del Río Sali", new[] { "Banda del Río Sali", "Tafí Viejo" } },
            { "Tafí Viejo", new[] { "Tafí Viejo", "Lules" } }
        };

        public frmRegistrarUsuario()
        {
            InitializeComponent();
            dtpFechaNacimiento.MaxDate = DateTime.Today;
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPartido.Items.Clear();
            cmbPartido.Text = "";
            cmbLocalidad.Items.Clear();
            cmbLocalidad.Text = "";

            if (cmbProvincia.Text != "" && partidosPorProvincia.ContainsKey(cmbProvincia.Text))
            {
                cmbPartido.Items.AddRange(partidosPorProvincia[cmbProvincia.Text]);
            }
        }

        private void cmbPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLocalidad.Items.Clear();
            cmbLocalidad.Text = "";

            if (cmbPartido.Text != "" && localidadesPorPartido.ContainsKey(cmbPartido.Text))
            {
                cmbLocalidad.Items.AddRange(localidadesPorPartido[cmbPartido.Text]);
            }
        }

        private void GenerarCredenciales()
        {
            string nombre = txtNombre.Text.Trim().ToLower();
            string apellido = txtApellido.Text.Trim().ToLower();
            string dni = txtDni.Text.Trim();

            if (nombre == "" || apellido == "" || dni.Length < 3)
                return;

            string inicial = nombre.Length > 0 ? nombre[0].ToString() : "";
            string ultimosTres = dni.Length >= 3 ? dni.Substring(dni.Length - 3) : dni;
            string usuario = inicial + apellido + ultimosTres;

            int contador = 2;
            string usuarioBase = usuario;
            while (ExisteUsuario(usuario))
            {
                usuario = usuarioBase + "_" + contador;
                contador++;
            }

            txtNombreUsuario.Text = usuario;
            txtContrasena.Text = GenerarContrasena();
        }

        private bool ExisteUsuario(string nombreUsuario)
        {
            foreach (Usuario u in DatosSistema.Usuarios)
            {
                if (u.NombreUsuario == nombreUsuario)
                    return true;
            }
            return false;
        }

        private string GenerarContrasena()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%";
            Random random = new Random();
            StringBuilder sb = new StringBuilder(8);
            for (int i = 0; i < 8; i++)
            {
                sb.Append(chars[random.Next(chars.Length)]);
            }
            return sb.ToString();
        }

        private bool ValidarSoloLetras(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return false;
            }
            return true;
        }

        private bool ValidarSoloNumeros(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private bool ValidarEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
                return false;

            int indiceArroba = email.IndexOf('@');
            int indicePunto = email.LastIndexOf('.');
            return indiceArroba > 0 && indicePunto > indiceArroba + 1 && indicePunto < email.Length - 1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el apellido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return;
            }
            if (txtDni.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el DNI.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Focus();
                return;
            }
            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el teléfono.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el email.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (cmbGenero.Text == "")
            {
                MessageBox.Show("Seleccione el género.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGenero.Focus();
                return;
            }
            if (cmbTipoUsuario.Text == "")
            {
                MessageBox.Show("Seleccione el tipo de usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipoUsuario.Focus();
                return;
            }

            // Validar formato
            if (!ValidarSoloLetras(txtNombre.Text.Trim()))
            {
                MessageBox.Show("El nombre solo debe contener letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            if (!ValidarSoloLetras(txtApellido.Text.Trim()))
            {
                MessageBox.Show("El apellido solo debe contener letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return;
            }
            if (!ValidarSoloNumeros(txtDni.Text.Trim()) || txtDni.Text.Trim().Length != 8)
            {
                MessageBox.Show("El DNI debe contener exactamente 8 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
                return;
            }
            if (!ValidarSoloNumeros(txtTelefono.Text.Trim()) || txtTelefono.Text.Trim().Length != 10)
            {
                MessageBox.Show("El teléfono debe contener exactamente 10 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return;
            }
            if (!ValidarEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("El email no es válido. Debe contener @ y un dominio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (txtAltura.Text.Trim() != "" && !ValidarSoloNumeros(txtAltura.Text.Trim()))
            {
                MessageBox.Show("La altura debe ser un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAltura.Focus();
                return;
            }
            if (txtCodPostal.Text.Trim().Length > 8)
            {
                MessageBox.Show(
                    "El código postal no puede superar los 8 caracteres.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtCodPostal.Focus();
                return;
            }
            if (dtpFechaNacimiento.Value > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaNacimiento.Focus();
                return;
            }

            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - dtpFechaNacimiento.Value.Year;
            if (dtpFechaNacimiento.Value.Date > hoy.AddYears(-edad)) edad--;
            if (edad < 18)
            {
                MessageBox.Show("El usuario debe ser mayor de 18 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaNacimiento.Focus();
                return;
            }

            // Verificar DNI único
            foreach (Usuario u in DatosSistema.Usuarios)
            {
                if (u.Dni == txtDni.Text.Trim())
                {
                    MessageBox.Show("El DNI ya está registrado en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDni.Focus();
                    return;
                }
            }

            // Generar credenciales
            GenerarCredenciales();

            // Crear usuario
            Usuario nuevoUsuario = new Usuario()
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Dni = txtDni.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Domicilio = ConstruirDomicilio(),
                Genero = cmbGenero.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                TipoUsuario = cmbTipoUsuario.Text,
                PrimerIngreso = true,
                NombreUsuario = txtNombreUsuario.Text,
                Contrasena = txtContrasena.Text
            };

            DatosSistema.Usuarios.Add(nuevoUsuario);

            MessageBox.Show(
                "Usuario registrado exitosamente.\n\n" +
                "Usuario: " + txtNombreUsuario.Text + "\n" +
                "Contraseña: " + txtContrasena.Text,
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            MessageBox.Show(
    "Se enviaron las credenciales al correo electrónico:\n\n" +
    txtEmail.Text,
    "FEXI",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtCalle.Clear();
            txtAltura.Clear();
            txtPiso.Clear();
            txtDepartamento.Clear();
            txtCodPostal.Clear();
            txtNombreUsuario.Clear();
            txtContrasena.Clear();
            cmbGenero.SelectedIndex = -1;
            cmbTipoUsuario.SelectedIndex = -1;
            cmbNacionalidad.SelectedIndex = -1;
            cmbProvincia.SelectedIndex = -1;
            cmbPartido.Items.Clear();
            cmbPartido.Text = "";
            cmbLocalidad.Items.Clear();
            cmbLocalidad.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            txtNombre.Focus();
        }

        private string ConstruirDomicilio()
        {
            StringBuilder sb = new StringBuilder();
            if (txtCalle.Text.Trim() != "") sb.Append(txtCalle.Text.Trim());
            if (txtAltura.Text.Trim() != "") sb.Append(" " + txtAltura.Text.Trim());
            if (txtPiso.Text.Trim() != "") sb.Append(" Piso " + txtPiso.Text.Trim());
            if (txtDepartamento.Text.Trim() != "") sb.Append(" Dpto " + txtDepartamento.Text.Trim());
            if (cmbLocalidad.Text != "") sb.Append(", " + cmbLocalidad.Text);
            if (cmbPartido.Text != "") sb.Append(", " + cmbPartido.Text);
            if (cmbProvincia.Text != "") sb.Append(", " + cmbProvincia.Text);
            return sb.ToString().Trim();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
