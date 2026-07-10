namespace TP1_2._3
{
    partial class frmEditarPerfil
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
            btnCancelar = new Button();
            btnGuardarCambios = new Button();
            dtpFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            cmbTipoUsuario = new ComboBox();
            cmbGenero = new ComboBox();
            lblTipoUsuario = new Label();
            lblGenero = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblTitulo = new Label();
            lblNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            lnkModificarContrasena = new LinkLabel();
            lblNacionalidad = new Label();
            cmbNacionalidad = new ComboBox();
            lblProvincia = new Label();
            cmbProvincia = new ComboBox();
            lblPartido = new Label();
            cmbPartido = new ComboBox();
            lblLocalidad = new Label();
            cmbLocalidad = new ComboBox();
            lblCalle = new Label();
            txtCalle = new TextBox();
            lblAltura = new Label();
            txtAltura = new TextBox();
            lblPiso = new Label();
            txtPiso = new TextBox();
            lblDepartamento = new Label();
            txtDepartamento = new TextBox();
            lblCodPostal = new Label();
            txtCodPostal = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(354, 639);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 30);
            btnCancelar.TabIndex = 132;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(111, 639);
            btnGuardarCambios.Margin = new Padding(3, 2, 3, 2);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(131, 30);
            btnGuardarCambios.TabIndex = 131;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(312, 296);
            dtpFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(219, 23);
            dtpFechaNacimiento.TabIndex = 130;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaNacimiento.Location = new Point(312, 275);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(149, 20);
            lblFechaNacimiento.TabIndex = 129;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Location = new Point(66, 358);
            cmbTipoUsuario.Margin = new Padding(3, 2, 3, 2);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(219, 23);
            cmbTipoUsuario.TabIndex = 128;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(66, 296);
            cmbGenero.Margin = new Padding(3, 2, 3, 2);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(219, 23);
            cmbGenero.TabIndex = 127;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoUsuario.Location = new Point(66, 338);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(114, 20);
            lblTipoUsuario.TabIndex = 126;
            lblTipoUsuario.Text = "Tipo de Usuario";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenero.Location = new Point(66, 275);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(57, 20);
            lblGenero.TabIndex = 125;
            lblGenero.Text = "Género";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(66, 240);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(466, 23);
            txtEmail.TabIndex = 124;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(66, 219);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 123;
            lblEmail.Text = "Email";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(312, 188);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(219, 23);
            txtTelefono.TabIndex = 122;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(312, 166);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 120;
            lblTelefono.Text = "Teléfono";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(66, 188);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(219, 23);
            txtDni.TabIndex = 121;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(66, 166);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 119;
            lblDni.Text = "DNI";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(312, 137);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(219, 23);
            txtApellido.TabIndex = 118;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(312, 116);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 117;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(66, 137);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(219, 23);
            txtNombre.TabIndex = 116;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(66, 116);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 115;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(191, 77);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(207, 20);
            lblDescripcion.TabIndex = 114;
            lblDescripcion.Text = "Modificá tus datos personales";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(200, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(186, 41);
            lblTitulo.TabIndex = 113;
            lblTitulo.Text = "Editar Perfil";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(66, 390);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(110, 19);
            lblNombreUsuario.TabIndex = 133;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = SystemColors.Control;
            txtNombreUsuario.Location = new Point(66, 410);
            txtNombreUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.ReadOnly = true;
            txtNombreUsuario.Size = new Size(219, 23);
            txtNombreUsuario.TabIndex = 134;
            txtNombreUsuario.TabStop = false;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContrasena.Location = new Point(312, 390);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(79, 19);
            lblContrasena.TabIndex = 135;
            lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = SystemColors.Control;
            txtContrasena.Location = new Point(312, 410);
            txtContrasena.Margin = new Padding(3, 2, 3, 2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.ReadOnly = true;
            txtContrasena.Size = new Size(219, 23);
            txtContrasena.TabIndex = 136;
            txtContrasena.TabStop = false;
            // 
            // lnkModificarContrasena
            // 
            lnkModificarContrasena.AutoSize = true;
            lnkModificarContrasena.Cursor = Cursors.Hand;
            lnkModificarContrasena.LinkBehavior = LinkBehavior.AlwaysUnderline;
            lnkModificarContrasena.Location = new Point(312, 433);
            lnkModificarContrasena.Name = "lnkModificarContrasena";
            lnkModificarContrasena.Size = new Size(119, 15);
            lnkModificarContrasena.TabIndex = 137;
            lnkModificarContrasena.TabStop = true;
            lnkModificarContrasena.Text = "Modificar contraseña";
            lnkModificarContrasena.LinkClicked += lnkModificarContrasena_LinkClicked;
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNacionalidad.Location = new Point(66, 461);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(87, 19);
            lblNacionalidad.TabIndex = 138;
            lblNacionalidad.Text = "Nacionalidad";
            // 
            // cmbNacionalidad
            // 
            cmbNacionalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNacionalidad.FormattingEnabled = true;
            cmbNacionalidad.Items.AddRange(new object[] { "Argentina", "Brasil", "Chile", "Uruguay", "Paraguay", "Bolivia", "Colombia", "México", "Perú", "Venezuela" });
            cmbNacionalidad.Location = new Point(66, 481);
            cmbNacionalidad.Margin = new Padding(3, 2, 3, 2);
            cmbNacionalidad.Name = "cmbNacionalidad";
            cmbNacionalidad.Size = new Size(219, 23);
            cmbNacionalidad.TabIndex = 139;
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProvincia.Location = new Point(312, 461);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(64, 19);
            lblProvincia.TabIndex = 140;
            lblProvincia.Text = "Provincia";
            // 
            // cmbProvincia
            // 
            cmbProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.Items.AddRange(new object[] { "Buenos Aires", "Córdoba", "Santa Fe", "Mendoza", "Tucumán" });
            cmbProvincia.Location = new Point(312, 481);
            cmbProvincia.Margin = new Padding(3, 2, 3, 2);
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(219, 23);
            cmbProvincia.TabIndex = 141;
            cmbProvincia.SelectedIndexChanged += cmbProvincia_SelectedIndexChanged;
            // 
            // lblPartido
            // 
            lblPartido.AutoSize = true;
            lblPartido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPartido.Location = new Point(66, 514);
            lblPartido.Name = "lblPartido";
            lblPartido.Size = new Size(118, 19);
            lblPartido.TabIndex = 142;
            lblPartido.Text = "Partido/Municipio";
            // 
            // cmbPartido
            // 
            cmbPartido.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPartido.FormattingEnabled = true;
            cmbPartido.Location = new Point(66, 533);
            cmbPartido.Margin = new Padding(3, 2, 3, 2);
            cmbPartido.Name = "cmbPartido";
            cmbPartido.Size = new Size(219, 23);
            cmbPartido.TabIndex = 143;
            cmbPartido.SelectedIndexChanged += cmbPartido_SelectedIndexChanged;
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocalidad.Location = new Point(312, 514);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(66, 19);
            lblLocalidad.TabIndex = 144;
            lblLocalidad.Text = "Localidad";
            // 
            // cmbLocalidad
            // 
            cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocalidad.FormattingEnabled = true;
            cmbLocalidad.Location = new Point(312, 533);
            cmbLocalidad.Margin = new Padding(3, 2, 3, 2);
            cmbLocalidad.Name = "cmbLocalidad";
            cmbLocalidad.Size = new Size(219, 23);
            cmbLocalidad.TabIndex = 145;
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCalle.Location = new Point(66, 564);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(38, 19);
            lblCalle.TabIndex = 146;
            lblCalle.Text = "Calle";
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(66, 584);
            txtCalle.Margin = new Padding(3, 2, 3, 2);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(123, 23);
            txtCalle.TabIndex = 147;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAltura.Location = new Point(200, 564);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(46, 19);
            lblAltura.TabIndex = 148;
            lblAltura.Text = "Altura";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(200, 584);
            txtAltura.Margin = new Padding(3, 2, 3, 2);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(85, 23);
            txtAltura.TabIndex = 149;
            // 
            // lblPiso
            // 
            lblPiso.AutoSize = true;
            lblPiso.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPiso.Location = new Point(296, 564);
            lblPiso.Name = "lblPiso";
            lblPiso.Size = new Size(34, 19);
            lblPiso.TabIndex = 150;
            lblPiso.Text = "Piso";
            // 
            // txtPiso
            // 
            txtPiso.Location = new Point(296, 584);
            txtPiso.Margin = new Padding(3, 2, 3, 2);
            txtPiso.Name = "txtPiso";
            txtPiso.Size = new Size(85, 23);
            txtPiso.TabIndex = 151;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartamento.Location = new Point(392, 564);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(98, 19);
            lblDepartamento.TabIndex = 152;
            lblDepartamento.Text = "Departamento";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(392, 584);
            txtDepartamento.Margin = new Padding(3, 2, 3, 2);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(85, 23);
            txtDepartamento.TabIndex = 153;
            // 
            // lblCodPostal
            // 
            lblCodPostal.AutoSize = true;
            lblCodPostal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodPostal.Location = new Point(487, 564);
            lblCodPostal.Name = "lblCodPostal";
            lblCodPostal.Size = new Size(77, 19);
            lblCodPostal.TabIndex = 154;
            lblCodPostal.Text = "Cód. Postal";
            // 
            // txtCodPostal
            // 
            txtCodPostal.Location = new Point(487, 584);
            txtCodPostal.Margin = new Padding(3, 2, 3, 2);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(85, 23);
            txtCodPostal.TabIndex = 155;
            // 
            // frmEditarPerfil
            // 
            AcceptButton = btnGuardarCambios;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            CancelButton = btnCancelar;
            ClientSize = new Size(612, 716);
            Controls.Add(txtCodPostal);
            Controls.Add(lblCodPostal);
            Controls.Add(txtDepartamento);
            Controls.Add(lblDepartamento);
            Controls.Add(txtPiso);
            Controls.Add(lblPiso);
            Controls.Add(txtAltura);
            Controls.Add(lblAltura);
            Controls.Add(txtCalle);
            Controls.Add(lblCalle);
            Controls.Add(cmbLocalidad);
            Controls.Add(lblLocalidad);
            Controls.Add(cmbPartido);
            Controls.Add(lblPartido);
            Controls.Add(cmbProvincia);
            Controls.Add(lblProvincia);
            Controls.Add(cmbNacionalidad);
            Controls.Add(lblNacionalidad);
            Controls.Add(lnkModificarContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(lblContrasena);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarCambios);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(cmbGenero);
            Controls.Add(lblTipoUsuario);
            Controls.Add(lblGenero);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEditarPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FEXI - Editar Perfil";
            Load += frmEditarPerfil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardarCambios;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblFechaNacimiento;
        private ComboBox cmbTipoUsuario;
        private ComboBox cmbGenero;
        private Label lblTipoUsuario;
        private Label lblGenero;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtDni;
        private Label lblDni;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblTitulo;
        private Label lblNombreUsuario;
        private TextBox txtNombreUsuario;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private LinkLabel lnkModificarContrasena;
        private Label lblNacionalidad;
        private ComboBox cmbNacionalidad;
        private Label lblProvincia;
        private ComboBox cmbProvincia;
        private Label lblPartido;
        private ComboBox cmbPartido;
        private Label lblLocalidad;
        private ComboBox cmbLocalidad;
        private Label lblCalle;
        private TextBox txtCalle;
        private Label lblAltura;
        private TextBox txtAltura;
        private Label lblPiso;
        private TextBox txtPiso;
        private Label lblDepartamento;
        private TextBox txtDepartamento;
        private Label lblCodPostal;
        private TextBox txtCodPostal;
    }
}
