namespace TP1_2._3
{
    partial class frmEditarPerfil
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
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(405, 550);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 40);
            btnCancelar.TabIndex = 132;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(127, 550);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(150, 40);
            btnGuardarCambios.TabIndex = 131;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(357, 395);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(250, 27);
            dtpFechaNacimiento.TabIndex = 130;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaNacimiento.Location = new Point(357, 367);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(177, 25);
            lblFechaNacimiento.TabIndex = 129;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Location = new Point(75, 478);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(250, 28);
            cmbTipoUsuario.TabIndex = 128;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(75, 395);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(250, 28);
            cmbGenero.TabIndex = 127;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoUsuario.Location = new Point(75, 450);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(137, 25);
            lblTipoUsuario.TabIndex = 126;
            lblTipoUsuario.Text = "Tipo de Usuario";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenero.Location = new Point(75, 367);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(69, 25);
            lblGenero.TabIndex = 125;
            lblGenero.Text = "Género";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(75, 320);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(532, 27);
            txtEmail.TabIndex = 124;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(75, 292);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 123;
            lblEmail.Text = "Email";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(357, 250);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(250, 27);
            txtTelefono.TabIndex = 122;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(357, 222);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(79, 25);
            lblTelefono.TabIndex = 120;
            lblTelefono.Text = "Teléfono";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(75, 250);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(250, 27);
            txtDni.TabIndex = 121;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(75, 222);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(43, 25);
            lblDni.TabIndex = 119;
            lblDni.Text = "DNI";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(357, 183);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 27);
            txtApellido.TabIndex = 118;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(357, 155);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 117;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(75, 183);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 116;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(75, 155);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 115;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(218, 103);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(250, 25);
            lblDescripcion.TabIndex = 114;
            lblDescripcion.Text = "Modificá tus datos personales";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(228, 53);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(229, 50);
            lblTitulo.TabIndex = 113;
            lblTitulo.Text = "Editar Perfil";
            // 
            // frmEditarPerfil
            // 
            AcceptButton = btnGuardarCambios;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            CancelButton = btnCancelar;
            ClientSize = new Size(682, 642);
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
    }
}