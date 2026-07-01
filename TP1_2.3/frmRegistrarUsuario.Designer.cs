namespace TP1_2._3
{
    partial class frmRegistrarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblTipoUsuario = new Label();
            lblGenero = new Label();
            cmbGenero = new ComboBox();
            cmbTipoUsuario = new ComboBox();
            txtDomicilio = new TextBox();
            lblDomicilio = new Label();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            txtContrasenaGenerada = new TextBox();
            lblContrasenaGenerada = new Label();
            txtUsuarioGenerado = new TextBox();
            lblUsuarioGenerado = new Label();
            btnGenerar = new Button();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(209, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(262, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar Usuario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(79, 92);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(79, 120);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(361, 120);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 27);
            txtApellido.TabIndex = 20;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(361, 92);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 11;
            lblApellido.Text = "Apellido";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(361, 187);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(250, 27);
            txtTelefono.TabIndex = 40;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(361, 159);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(79, 25);
            lblTelefono.TabIndex = 23;
            lblTelefono.Text = "Teléfono";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(79, 187);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(250, 27);
            txtDni.TabIndex = 30;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(79, 159);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(43, 25);
            lblDni.TabIndex = 21;
            lblDni.Text = "DNI";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(79, 257);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(532, 27);
            txtEmail.TabIndex = 50;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(79, 229);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 41;
            lblEmail.Text = "Email";
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoUsuario.Location = new Point(361, 304);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(137, 25);
            lblTipoUsuario.TabIndex = 52;
            lblTipoUsuario.Text = "Tipo de Usuario";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenero.Location = new Point(79, 304);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(69, 25);
            lblGenero.TabIndex = 51;
            lblGenero.Text = "Género";
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(79, 332);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(250, 28);
            cmbGenero.TabIndex = 60;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Location = new Point(361, 332);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(250, 28);
            cmbTipoUsuario.TabIndex = 70;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(361, 409);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(250, 27);
            txtDomicilio.TabIndex = 90;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDomicilio.Location = new Point(361, 381);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(87, 25);
            lblDomicilio.TabIndex = 72;
            lblDomicilio.Text = "Domicilio";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaNacimiento.Location = new Point(79, 381);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(177, 25);
            lblFechaNacimiento.TabIndex = 71;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(79, 409);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(250, 27);
            dtpFechaNacimiento.TabIndex = 80;
            // 
            // txtContrasenaGenerada
            // 
            txtContrasenaGenerada.Location = new Point(361, 483);
            txtContrasenaGenerada.Name = "txtContrasenaGenerada";
            txtContrasenaGenerada.ReadOnly = true;
            txtContrasenaGenerada.Size = new Size(250, 27);
            txtContrasenaGenerada.TabIndex = 95;
            txtContrasenaGenerada.TabStop = false;
            // 
            // lblContrasenaGenerada
            // 
            lblContrasenaGenerada.AutoSize = true;
            lblContrasenaGenerada.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContrasenaGenerada.Location = new Point(361, 455);
            lblContrasenaGenerada.Name = "lblContrasenaGenerada";
            lblContrasenaGenerada.Size = new Size(181, 25);
            lblContrasenaGenerada.TabIndex = 92;
            lblContrasenaGenerada.Text = "Contraseña Generada";
            // 
            // txtUsuarioGenerado
            // 
            txtUsuarioGenerado.Location = new Point(79, 483);
            txtUsuarioGenerado.Name = "txtUsuarioGenerado";
            txtUsuarioGenerado.ReadOnly = true;
            txtUsuarioGenerado.Size = new Size(250, 27);
            txtUsuarioGenerado.TabIndex = 93;
            txtUsuarioGenerado.TabStop = false;
            // 
            // lblUsuarioGenerado
            // 
            lblUsuarioGenerado.AutoSize = true;
            lblUsuarioGenerado.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuarioGenerado.Location = new Point(79, 455);
            lblUsuarioGenerado.Name = "lblUsuarioGenerado";
            lblUsuarioGenerado.Size = new Size(154, 25);
            lblUsuarioGenerado.TabIndex = 91;
            lblUsuarioGenerado.Text = "Usuario Generado";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(131, 555);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(150, 40);
            btnGenerar.TabIndex = 100;
            btnGenerar.Text = "Generar Datos";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(409, 555);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 40);
            btnRegistrar.TabIndex = 110;
            btnRegistrar.Text = "Registrar Usuario";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // frmRegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(682, 633);
            Controls.Add(btnRegistrar);
            Controls.Add(btnGenerar);
            Controls.Add(txtContrasenaGenerada);
            Controls.Add(lblContrasenaGenerada);
            Controls.Add(txtUsuarioGenerado);
            Controls.Add(lblUsuarioGenerado);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtDomicilio);
            Controls.Add(lblDomicilio);
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
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegistrarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FEXI - Registrar Usuario";
            Load += frmRegistrarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtDni;
        private Label lblDni;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblTipoUsuario;
        private Label lblGenero;
        private ComboBox cmbGenero;
        private ComboBox cmbTipoUsuario;
        private TextBox txtDomicilio;
        private Label lblDomicilio;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtContrasenaGenerada;
        private Label lblContrasenaGenerada;
        private TextBox txtUsuarioGenerado;
        private Label lblUsuarioGenerado;
        private Button btnGenerar;
        private Button btnRegistrar;
    }
}