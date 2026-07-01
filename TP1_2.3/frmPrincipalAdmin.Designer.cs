namespace TP1_2._3
{
    partial class frmPrincipalAdmin
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
            lblTituloAdmin = new Label();
            lblBienvenidaAdmin = new Label();
            btnRegistrarUsuario = new Button();
            btnEditarPerfil = new Button();
            btnCerrarSesion = new Button();
            lblUsuario = new Label();
            SuspendLayout();
            // 
            // lblTituloAdmin
            // 
            lblTituloAdmin.AutoSize = true;
            lblTituloAdmin.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloAdmin.Location = new Point(298, 24);
            lblTituloAdmin.Name = "lblTituloAdmin";
            lblTituloAdmin.Size = new Size(98, 50);
            lblTituloAdmin.TabIndex = 0;
            lblTituloAdmin.Text = "FEXI";
            // 
            // lblBienvenidaAdmin
            // 
            lblBienvenidaAdmin.AutoSize = true;
            lblBienvenidaAdmin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenidaAdmin.Location = new Point(239, 74);
            lblBienvenidaAdmin.Name = "lblBienvenidaAdmin";
            lblBienvenidaAdmin.Size = new Size(202, 25);
            lblBienvenidaAdmin.TabIndex = 1;
            lblBienvenidaAdmin.Text = "Panel de Administración";
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.Location = new Point(231, 198);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(220, 50);
            btnRegistrarUsuario.TabIndex = 2;
            btnRegistrarUsuario.Text = "Registrar Usuario";
            btnRegistrarUsuario.UseVisualStyleBackColor = true;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // btnEditarPerfil
            // 
            btnEditarPerfil.Location = new Point(231, 254);
            btnEditarPerfil.Name = "btnEditarPerfil";
            btnEditarPerfil.Size = new Size(220, 50);
            btnEditarPerfil.TabIndex = 3;
            btnEditarPerfil.Text = "Editar Mi Perfil";
            btnEditarPerfil.UseVisualStyleBackColor = true;
            btnEditarPerfil.Click += btnEditarPerfil_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(231, 334);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(220, 50);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(231, 134);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(222, 25);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Bienvenido, Administrador";
            // 
            // frmPrincipalAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(682, 428);
            Controls.Add(lblUsuario);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnEditarPerfil);
            Controls.Add(btnRegistrarUsuario);
            Controls.Add(lblBienvenidaAdmin);
            Controls.Add(lblTituloAdmin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmPrincipalAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FEXI - Panel Administrador";
            Load += frmPrincipalAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloAdmin;
        private Label lblBienvenidaAdmin;
        private Button btnRegistrarUsuario;
        private Button btnEditarPerfil;
        private Button btnCerrarSesion;
        private Label lblUsuario;
    }
}