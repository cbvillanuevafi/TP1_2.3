namespace TP1_2._3
{
    partial class frmRegistrarUsuario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelMain = new Panel();
            lblTitulo = new Label();
            grpDatosPersonales = new GroupBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblGenero = new Label();
            cmbGenero = new ComboBox();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblTipoUsuario = new Label();
            cmbTipoUsuario = new ComboBox();
            grpUbicacion = new GroupBox();
            lblNacionalidad = new Label();
            cmbNacionalidad = new ComboBox();
            lblProvincia = new Label();
            cmbProvincia = new ComboBox();
            lblPartido = new Label();
            cmbPartido = new ComboBox();
            lblLocalidad = new Label();
            cmbLocalidad = new ComboBox();
            lblCodPostal = new Label();
            txtCodPostal = new TextBox();
            lblCalle = new Label();
            txtCalle = new TextBox();
            lblAltura = new Label();
            txtAltura = new TextBox();
            lblPiso = new Label();
            txtPiso = new TextBox();
            lblDepartamento = new Label();
            txtDepartamento = new TextBox();
            grpCredenciales = new GroupBox();
            lblNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            panelMain.SuspendLayout();
            grpDatosPersonales.SuspendLayout();
            grpUbicacion.SuspendLayout();
            grpCredenciales.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.Controls.Add(lblTitulo);
            panelMain.Controls.Add(grpDatosPersonales);
            panelMain.Controls.Add(grpUbicacion);
            panelMain.Controls.Add(grpCredenciales);
            panelMain.Controls.Add(btnRegistrar);
            panelMain.Controls.Add(btnCancelar);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(508, 660);
            panelMain.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.DarkBlue;
            lblTitulo.Location = new Point(158, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(192, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar Usuario";
            // 
            // grpDatosPersonales
            // 
            grpDatosPersonales.Controls.Add(lblNombre);
            grpDatosPersonales.Controls.Add(txtNombre);
            grpDatosPersonales.Controls.Add(lblApellido);
            grpDatosPersonales.Controls.Add(txtApellido);
            grpDatosPersonales.Controls.Add(lblDni);
            grpDatosPersonales.Controls.Add(txtDni);
            grpDatosPersonales.Controls.Add(lblTelefono);
            grpDatosPersonales.Controls.Add(txtTelefono);
            grpDatosPersonales.Controls.Add(lblEmail);
            grpDatosPersonales.Controls.Add(txtEmail);
            grpDatosPersonales.Controls.Add(lblGenero);
            grpDatosPersonales.Controls.Add(cmbGenero);
            grpDatosPersonales.Controls.Add(lblFechaNacimiento);
            grpDatosPersonales.Controls.Add(dtpFechaNacimiento);
            grpDatosPersonales.Controls.Add(lblTipoUsuario);
            grpDatosPersonales.Controls.Add(cmbTipoUsuario);
            grpDatosPersonales.ForeColor = Color.DarkBlue;
            grpDatosPersonales.Location = new Point(18, 49);
            grpDatosPersonales.Margin = new Padding(3, 2, 3, 2);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Padding = new Padding(3, 2, 3, 2);
            grpDatosPersonales.Size = new Size(464, 210);
            grpDatosPersonales.TabIndex = 1;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "Datos Personales *";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(13, 26);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre *";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(13, 44);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(241, 26);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(59, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido *";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(241, 44);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(210, 23);
            txtApellido.TabIndex = 2;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(13, 71);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 15);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI *";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(13, 88);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(210, 23);
            txtDni.TabIndex = 3;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(241, 71);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(60, 15);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono *";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(241, 88);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(210, 23);
            txtTelefono.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(13, 116);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email *";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(13, 134);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(241, 116);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(53, 15);
            lblGenero.TabIndex = 10;
            lblGenero.Text = "Género *";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
            cmbGenero.Location = new Point(241, 134);
            cmbGenero.Margin = new Padding(3, 2, 3, 2);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(210, 23);
            cmbGenero.TabIndex = 6;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(13, 161);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(127, 15);
            lblFechaNacimiento.TabIndex = 12;
            lblFechaNacimiento.Text = "Fecha de Nacimiento *";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(13, 178);
            dtpFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(210, 23);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Location = new Point(241, 161);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(97, 15);
            lblTipoUsuario.TabIndex = 14;
            lblTipoUsuario.Text = "Tipo de Usuario *";
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Items.AddRange(new object[] { "Administrador", "General" });
            cmbTipoUsuario.Location = new Point(241, 178);
            cmbTipoUsuario.Margin = new Padding(3, 2, 3, 2);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(210, 23);
            cmbTipoUsuario.TabIndex = 8;
            // 
            // grpUbicacion
            // 
            grpUbicacion.Controls.Add(lblNacionalidad);
            grpUbicacion.Controls.Add(cmbNacionalidad);
            grpUbicacion.Controls.Add(lblProvincia);
            grpUbicacion.Controls.Add(cmbProvincia);
            grpUbicacion.Controls.Add(lblPartido);
            grpUbicacion.Controls.Add(cmbPartido);
            grpUbicacion.Controls.Add(lblLocalidad);
            grpUbicacion.Controls.Add(cmbLocalidad);
            grpUbicacion.Controls.Add(lblCodPostal);
            grpUbicacion.Controls.Add(txtCodPostal);
            grpUbicacion.Controls.Add(lblCalle);
            grpUbicacion.Controls.Add(txtCalle);
            grpUbicacion.Controls.Add(lblAltura);
            grpUbicacion.Controls.Add(txtAltura);
            grpUbicacion.Controls.Add(lblPiso);
            grpUbicacion.Controls.Add(txtPiso);
            grpUbicacion.Controls.Add(lblDepartamento);
            grpUbicacion.Controls.Add(txtDepartamento);
            grpUbicacion.ForeColor = Color.DarkBlue;
            grpUbicacion.Location = new Point(18, 263);
            grpUbicacion.Margin = new Padding(3, 2, 3, 2);
            grpUbicacion.Name = "grpUbicacion";
            grpUbicacion.Padding = new Padding(3, 2, 3, 2);
            grpUbicacion.Size = new Size(464, 208);
            grpUbicacion.TabIndex = 2;
            grpUbicacion.TabStop = false;
            grpUbicacion.Text = "Ubicación";
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(13, 26);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(77, 15);
            lblNacionalidad.TabIndex = 0;
            lblNacionalidad.Text = "Nacionalidad";
            // 
            // cmbNacionalidad
            // 
            cmbNacionalidad.FormattingEnabled = true;
            cmbNacionalidad.Items.AddRange(new object[] { "Argentina", "Brasil", "Chile", "Uruguay", "Paraguay", "Bolivia", "Colombia", "México", "Perú", "Venezuela" });
            cmbNacionalidad.Location = new Point(13, 44);
            cmbNacionalidad.Margin = new Padding(3, 2, 3, 2);
            cmbNacionalidad.Name = "cmbNacionalidad";
            cmbNacionalidad.Size = new Size(210, 23);
            cmbNacionalidad.TabIndex = 9;
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Location = new Point(241, 26);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(56, 15);
            lblProvincia.TabIndex = 2;
            lblProvincia.Text = "Provincia";
            // 
            // cmbProvincia
            // 
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.Items.AddRange(new object[] { "Buenos Aires", "Córdoba", "Santa Fe", "Mendoza", "Tucumán" });
            cmbProvincia.Location = new Point(241, 44);
            cmbProvincia.Margin = new Padding(3, 2, 3, 2);
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(210, 23);
            cmbProvincia.TabIndex = 10;
            cmbProvincia.SelectedIndexChanged += cmbProvincia_SelectedIndexChanged;
            // 
            // lblPartido
            // 
            lblPartido.AutoSize = true;
            lblPartido.Location = new Point(13, 71);
            lblPartido.Name = "lblPartido";
            lblPartido.Size = new Size(104, 15);
            lblPartido.TabIndex = 4;
            lblPartido.Text = "Partido/Municipio";
            // 
            // cmbPartido
            // 
            cmbPartido.FormattingEnabled = true;
            cmbPartido.Location = new Point(13, 88);
            cmbPartido.Margin = new Padding(3, 2, 3, 2);
            cmbPartido.Name = "cmbPartido";
            cmbPartido.Size = new Size(210, 23);
            cmbPartido.TabIndex = 11;
            cmbPartido.SelectedIndexChanged += cmbPartido_SelectedIndexChanged;
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Location = new Point(241, 71);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(58, 15);
            lblLocalidad.TabIndex = 6;
            lblLocalidad.Text = "Localidad";
            // 
            // cmbLocalidad
            // 
            cmbLocalidad.FormattingEnabled = true;
            cmbLocalidad.Location = new Point(241, 88);
            cmbLocalidad.Margin = new Padding(3, 2, 3, 2);
            cmbLocalidad.Name = "cmbLocalidad";
            cmbLocalidad.Size = new Size(210, 23);
            cmbLocalidad.TabIndex = 12;
            // 
            // lblCodPostal
            // 
            lblCodPostal.AutoSize = true;
            lblCodPostal.Location = new Point(13, 116);
            lblCodPostal.Name = "lblCodPostal";
            lblCodPostal.Size = new Size(81, 15);
            lblCodPostal.TabIndex = 8;
            lblCodPostal.Text = "Código Postal";
            // 
            // txtCodPostal
            // 
            txtCodPostal.Location = new Point(13, 134);
            txtCodPostal.Margin = new Padding(3, 2, 3, 2);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(97, 23);
            txtCodPostal.TabIndex = 13;
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(122, 116);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(33, 15);
            lblCalle.TabIndex = 10;
            lblCalle.Text = "Calle";
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(122, 134);
            txtCalle.Margin = new Padding(3, 2, 3, 2);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(123, 23);
            txtCalle.TabIndex = 14;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(254, 116);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(39, 15);
            lblAltura.TabIndex = 12;
            lblAltura.Text = "Altura";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(254, 134);
            txtAltura.Margin = new Padding(3, 2, 3, 2);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(88, 23);
            txtAltura.TabIndex = 15;
            // 
            // lblPiso
            // 
            lblPiso.AutoSize = true;
            lblPiso.Location = new Point(350, 116);
            lblPiso.Name = "lblPiso";
            lblPiso.Size = new Size(29, 15);
            lblPiso.TabIndex = 14;
            lblPiso.Text = "Piso";
            // 
            // txtPiso
            // 
            txtPiso.Location = new Point(350, 134);
            txtPiso.Margin = new Padding(3, 2, 3, 2);
            txtPiso.Name = "txtPiso";
            txtPiso.Size = new Size(97, 23);
            txtPiso.TabIndex = 16;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(13, 158);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(83, 15);
            lblDepartamento.TabIndex = 16;
            lblDepartamento.Text = "Departamento";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(13, 175);
            txtDepartamento.Margin = new Padding(3, 2, 3, 2);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(97, 23);
            txtDepartamento.TabIndex = 17;
            // 
            // grpCredenciales
            // 
            grpCredenciales.Controls.Add(lblNombreUsuario);
            grpCredenciales.Controls.Add(txtNombreUsuario);
            grpCredenciales.Controls.Add(lblContrasena);
            grpCredenciales.Controls.Add(txtContrasena);
            grpCredenciales.ForeColor = Color.DarkBlue;
            grpCredenciales.Location = new Point(18, 478);
            grpCredenciales.Margin = new Padding(3, 2, 3, 2);
            grpCredenciales.Name = "grpCredenciales";
            grpCredenciales.Padding = new Padding(3, 2, 3, 2);
            grpCredenciales.Size = new Size(464, 75);
            grpCredenciales.TabIndex = 3;
            grpCredenciales.TabStop = false;
            grpCredenciales.Text = "Credenciales (se generan automáticamente)";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(13, 22);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(110, 15);
            lblNombreUsuario.TabIndex = 0;
            lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = SystemColors.Control;
            txtNombreUsuario.Location = new Point(13, 40);
            txtNombreUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.ReadOnly = true;
            txtNombreUsuario.Size = new Size(210, 23);
            txtNombreUsuario.TabIndex = 20;
            txtNombreUsuario.TabStop = false;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(241, 22);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 2;
            lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = SystemColors.Control;
            txtContrasena.Location = new Point(241, 40);
            txtContrasena.Margin = new Padding(3, 2, 3, 2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.ReadOnly = true;
            txtContrasena.Size = new Size(210, 23);
            txtContrasena.TabIndex = 21;
            txtContrasena.TabStop = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.DarkBlue;
            btnRegistrar.Location = new Point(122, 564);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(114, 30);
            btnRegistrar.TabIndex = 22;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Segoe UI", 10.2F);
            btnCancelar.ForeColor = Color.DarkBlue;
            btnCancelar.Location = new Point(262, 564);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 30);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmRegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(508, 660);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegistrarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FEXI - Registrar Usuario";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            grpDatosPersonales.ResumeLayout(false);
            grpDatosPersonales.PerformLayout();
            grpUbicacion.ResumeLayout(false);
            grpUbicacion.PerformLayout();
            grpCredenciales.ResumeLayout(false);
            grpCredenciales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Label lblTitulo;
        private GroupBox grpDatosPersonales;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblGenero;
        private ComboBox cmbGenero;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblTipoUsuario;
        private ComboBox cmbTipoUsuario;
        private GroupBox grpUbicacion;
        private Label lblNacionalidad;
        private ComboBox cmbNacionalidad;
        private Label lblProvincia;
        private ComboBox cmbProvincia;
        private Label lblPartido;
        private ComboBox cmbPartido;
        private Label lblLocalidad;
        private ComboBox cmbLocalidad;
        private Label lblCodPostal;
        private TextBox txtCodPostal;
        private Label lblCalle;
        private TextBox txtCalle;
        private Label lblAltura;
        private TextBox txtAltura;
        private Label lblPiso;
        private TextBox txtPiso;
        private Label lblDepartamento;
        private TextBox txtDepartamento;
        private GroupBox grpCredenciales;
        private Label lblNombreUsuario;
        private TextBox txtNombreUsuario;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private Button btnRegistrar;
        private Button btnCancelar;
    }
}
