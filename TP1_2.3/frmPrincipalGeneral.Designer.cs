namespace TP1_2._3
{
    partial class frmPrincipalGeneral
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
            lblTituloGeneral = new Label();
            lblBienvenidaGeneral = new Label();
            btnEditarPerfil = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // lblTituloGeneral
            // 
            lblTituloGeneral.AutoSize = true;
            lblTituloGeneral.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloGeneral.Location = new Point(275, 51);
            lblTituloGeneral.Name = "lblTituloGeneral";
            lblTituloGeneral.Size = new Size(253, 41);
            lblTituloGeneral.TabIndex = 0;
            lblTituloGeneral.Text = "Panel de Usuario";
            // 
            // lblBienvenidaGeneral
            // 
            lblBienvenidaGeneral.AutoSize = true;
            lblBienvenidaGeneral.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenidaGeneral.Location = new Point(316, 102);
            lblBienvenidaGeneral.Name = "lblBienvenidaGeneral";
            lblBienvenidaGeneral.Size = new Size(164, 25);
            lblBienvenidaGeneral.TabIndex = 1;
            lblBienvenidaGeneral.Text = "Bienvenido Usuario";
            // 
            // btnEditarPerfil
            // 
            btnEditarPerfil.Location = new Point(288, 184);
            btnEditarPerfil.Name = "btnEditarPerfil";
            btnEditarPerfil.Size = new Size(220, 50);
            btnEditarPerfil.TabIndex = 2;
            btnEditarPerfil.Text = "Editar Mi Perfil";
            btnEditarPerfil.UseVisualStyleBackColor = true;
            btnEditarPerfil.Click += btnEditarPerfil_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(288, 240);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(220, 50);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // frmPrincipalGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnEditarPerfil);
            Controls.Add(lblBienvenidaGeneral);
            Controls.Add(lblTituloGeneral);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmPrincipalGeneral";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FEXI - Panel General";
            Load += frmPrincipalGeneral_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloGeneral;
        private Label lblBienvenidaGeneral;
        private Button btnEditarPerfil;
        private Button btnCerrarSesion;
    }
}