namespace TP1_2._3
{
    partial class frmRecuperarContrasena
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
            lblEstado = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            btnEnviarCodigo = new Button();
            btnValidarCodigo = new Button();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            txtConfirmarContrasena = new TextBox();
            lblConfirmarContrasena = new Label();
            txtNuevaContrasena = new TextBox();
            lblNuevaContrasena = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(172, 50);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(326, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Recuperar Contraseña";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(34, 115);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(276, 25);
            lblEstado.TabIndex = 1;
            lblEstado.Text = "Ingresá tu usuario para comenzar";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(34, 166);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(72, 25);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(34, 194);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(250, 27);
            txtUsuario.TabIndex = 10;
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.Location = new Point(290, 191);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(150, 32);
            btnEnviarCodigo.TabIndex = 20;
            btnEnviarCodigo.Text = "Enviar código";
            btnEnviarCodigo.UseVisualStyleBackColor = true;
            btnEnviarCodigo.Click += btnEnviarCodigo_Click;
            // 
            // btnValidarCodigo
            // 
            btnValidarCodigo.Enabled = false;
            btnValidarCodigo.Location = new Point(290, 269);
            btnValidarCodigo.Name = "btnValidarCodigo";
            btnValidarCodigo.Size = new Size(150, 32);
            btnValidarCodigo.TabIndex = 40;
            btnValidarCodigo.Text = "Validar código";
            btnValidarCodigo.UseVisualStyleBackColor = true;
            btnValidarCodigo.Click += btnValidarCodigo_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(34, 272);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(250, 27);
            txtCodigo.TabIndex = 30;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(34, 244);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(71, 25);
            lblCodigo.TabIndex = 21;
            lblCodigo.Text = "Código";
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Enabled = false;
            txtConfirmarContrasena.Location = new Point(34, 433);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.PasswordChar = '*';
            txtConfirmarContrasena.Size = new Size(406, 27);
            txtConfirmarContrasena.TabIndex = 60;
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.AutoSize = true;
            lblConfirmarContrasena.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmarContrasena.Location = new Point(34, 405);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(182, 25);
            lblConfirmarContrasena.TabIndex = 51;
            lblConfirmarContrasena.Text = "Confirmar contraseña";
            // 
            // txtNuevaContrasena
            // 
            txtNuevaContrasena.Enabled = false;
            txtNuevaContrasena.Location = new Point(34, 355);
            txtNuevaContrasena.Name = "txtNuevaContrasena";
            txtNuevaContrasena.PasswordChar = '*';
            txtNuevaContrasena.Size = new Size(406, 27);
            txtNuevaContrasena.TabIndex = 50;
            // 
            // lblNuevaContrasena
            // 
            lblNuevaContrasena.AutoSize = true;
            lblNuevaContrasena.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNuevaContrasena.Location = new Point(34, 327);
            lblNuevaContrasena.Name = "lblNuevaContrasena";
            lblNuevaContrasena.Size = new Size(153, 25);
            lblNuevaContrasena.TabIndex = 41;
            lblNuevaContrasena.Text = "Nueva contraseña";
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Location = new Point(264, 506);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 35);
            btnGuardar.TabIndex = 70;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmRecuperarContrasena
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(632, 593);
            Controls.Add(btnGuardar);
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(lblConfirmarContrasena);
            Controls.Add(txtNuevaContrasena);
            Controls.Add(lblNuevaContrasena);
            Controls.Add(btnValidarCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(btnEnviarCodigo);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblEstado);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRecuperarContrasena";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FEXI - Recuperar Contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblEstado;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Button btnEnviarCodigo;
        private Button btnValidarCodigo;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtConfirmarContrasena;
        private Label lblConfirmarContrasena;
        private TextBox txtNuevaContrasena;
        private Label lblNuevaContrasena;
        private Button btnGuardar;
    }
}