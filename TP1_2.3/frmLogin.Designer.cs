namespace TP1_2._3
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            lblContrasena = new Label();
            btnMostrar = new Button();
            btnLogin = new Button();
            lnkRecuperar = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.DarkBlue;
            lblTitulo.Location = new Point(189, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(98, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "FEXI";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.DarkBlue;
            lblSubtitulo.Location = new Point(116, 65);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(250, 23);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Sistema de Gestión de Usuarios";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.DarkBlue;
            lblUsuario.Location = new Point(201, 131);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(68, 23);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = Color.DarkBlue;
            txtUsuario.Location = new Point(89, 157);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 27);
            txtUsuario.TabIndex = 0;
            // 
            // txtContrasena
            // 
            txtContrasena.ForeColor = Color.DarkBlue;
            txtContrasena.Location = new Point(89, 237);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(300, 27);
            txtContrasena.TabIndex = 10;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContrasena.ForeColor = Color.DarkBlue;
            lblContrasena.Location = new Point(189, 211);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(97, 23);
            lblContrasena.TabIndex = 4;
            lblContrasena.Text = "Contraseña";
            lblContrasena.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMostrar
            // 
            btnMostrar.AutoSize = true;
            btnMostrar.ForeColor = Color.DarkBlue;
            btnMostrar.Location = new Point(395, 237);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(45, 30);
            btnMostrar.TabIndex = 11;
            btnMostrar.TabStop = false;
            btnMostrar.Text = "Ver";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.DarkBlue;
            btnLogin.Location = new Point(163, 312);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 40);
            btnLogin.TabIndex = 20;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkRecuperar
            // 
            lnkRecuperar.AutoSize = true;
            lnkRecuperar.Cursor = Cursors.Hand;
            lnkRecuperar.LinkBehavior = LinkBehavior.AlwaysUnderline;
            lnkRecuperar.Location = new Point(149, 359);
            lnkRecuperar.Name = "lnkRecuperar";
            lnkRecuperar.Size = new Size(178, 20);
            lnkRecuperar.TabIndex = 30;
            lnkRecuperar.TabStop = true;
            lnkRecuperar.Text = "¿Olvidaste tu contraseña?";
            lnkRecuperar.LinkClicked += lnkRecuperar_LinkClicked;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(482, 403);
            Controls.Add(lnkRecuperar);
            Controls.Add(btnLogin);
            Controls.Add(btnMostrar);
            Controls.Add(txtContrasena);
            Controls.Add(lblContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FEXI - Inicio de Sesión";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label lblContrasena;
        private Button btnMostrar;
        private Button btnLogin;
        private LinkLabel lnkRecuperar;
    }
}
