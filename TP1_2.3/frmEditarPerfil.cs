using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TP1_2._3
{
    public partial class frmEditarPerfil : Form
    {
        private Usuario usuarioEditar;

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
            { "Lomas de Zamora", new[] { "Lomas de Zamora", "Lanús", "Avellaneda" } },
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
            cmbTipoUsuario.Items.Add("Empleado");

            if (usuarioEditar != null)
            {
                txtNombre.Text = usuarioEditar.Nombre;
                txtApellido.Text = usuarioEditar.Apellido;
                txtDni.Text = usuarioEditar.Dni;
                txtTelefono.Text = usuarioEditar.Telefono;
                txtEmail.Text = usuarioEditar.Email;
                cmbGenero.Text = usuarioEditar.Genero;
                cmbTipoUsuario.Text = usuarioEditar.TipoUsuario;
                txtNombreUsuario.Text = usuarioEditar.NombreUsuario;
                txtContrasena.Text = usuarioEditar.Contrasena;

                if (usuarioEditar.FechaNacimiento >= dtpFechaNacimiento.MinDate)
                {
                    dtpFechaNacimiento.Value = usuarioEditar.FechaNacimiento;
                }
            }

            txtDni.Enabled = false;
            cmbTipoUsuario.Enabled = false;
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

        private void lnkModificarContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCambioContrasena cambio = new frmCambioContrasena(usuarioEditar);
            cambio.ShowDialog();
            txtContrasena.Text = usuarioEditar.Contrasena;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre.", "FEXI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            foreach (char caracter in txtNombre.Text)
            {
                if (!char.IsLetter(caracter) && caracter != ' ')
                {
                    MessageBox.Show("El nombre solo puede contener letras.", "FEXI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }
            }

            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un apellido.", "FEXI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return;
            }

            foreach (char caracter in txtApellido.Text)
            {
                if (!char.IsLetter(caracter) && caracter != ' ')
                {
                    MessageBox.Show("El apellido solo puede contener letras.", "FEXI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtApellido.Focus();
                    return;
                }
            }

            if (txtTelefono.Text.Length != 10)
            {
                MessageBox.Show("El teléfono debe tener 10 dígitos.", "FEXI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return;
            }

            foreach (char c in txtTelefono.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("El teléfono debe contener solo números.", "FEXI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelefono.Focus();
                    return;
                }
            }

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Ingrese un email válido.", "FEXI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.", "FEXI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaLimite = DateTime.Today.AddYears(-18);
            if (dtpFechaNacimiento.Value.Date > fechaLimite)
            {
                MessageBox.Show("El usuario debe ser mayor de 18 años.", "FEXI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaNacimiento.Focus();
                return;
            }

            if (txtAltura.Text.Trim() != "")
            {
                foreach (char c in txtAltura.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        MessageBox.Show("La altura debe ser un valor numérico.", "FEXI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAltura.Focus();
                        return;
                    }
                }
            }

            usuarioEditar.Nombre = txtNombre.Text;
            usuarioEditar.Apellido = txtApellido.Text;
            usuarioEditar.Telefono = txtTelefono.Text;
            usuarioEditar.Email = txtEmail.Text;
            usuarioEditar.Genero = cmbGenero.Text;
            usuarioEditar.FechaNacimiento = dtpFechaNacimiento.Value;
            usuarioEditar.Domicilio = ConstruirDomicilio();

            MessageBox.Show("Perfil actualizado correctamente.", "FEXI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
