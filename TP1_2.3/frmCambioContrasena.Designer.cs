namespace TP1_2._3
{
    partial class frmCambioContrasena
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
            lblMensaje = new Label();
            lblTituloCContraseña = new Label();
            lblNuevaContrasena = new Label();
            txtNuevaContrasena = new TextBox();
            lblConfirmarContrasena = new Label();
            btnConfirmar = new Button();
            txtConfirmarContrasena = new TextBox();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.DarkBlue;
            lblMensaje.Location = new Point(85, 107);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(498, 23);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "Primer ingreso al Sistema. Cambie la contraseña para continuar.";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloCContraseña
            // 
            lblTituloCContraseña.AutoSize = true;
            lblTituloCContraseña.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloCContraseña.ForeColor = Color.DarkBlue;
            lblTituloCContraseña.Location = new Point(281, 33);
            lblTituloCContraseña.Name = "lblTituloCContraseña";
            lblTituloCContraseña.Size = new Size(98, 50);
            lblTituloCContraseña.TabIndex = 3;
            lblTituloCContraseña.Text = "FEXI";
            lblTituloCContraseña.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNuevaContrasena
            // 
            lblNuevaContrasena.AutoSize = true;
            lblNuevaContrasena.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNuevaContrasena.ForeColor = Color.DarkBlue;
            lblNuevaContrasena.Location = new Point(255, 161);
            lblNuevaContrasena.Name = "lblNuevaContrasena";
            lblNuevaContrasena.Size = new Size(151, 23);
            lblNuevaContrasena.TabIndex = 4;
            lblNuevaContrasena.Text = "Nueva Contraseña";
            lblNuevaContrasena.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNuevaContrasena
            // 
            txtNuevaContrasena.ForeColor = Color.DarkBlue;
            txtNuevaContrasena.Location = new Point(186, 208);
            txtNuevaContrasena.Name = "txtNuevaContrasena";
            txtNuevaContrasena.Size = new Size(300, 27);
            txtNuevaContrasena.TabIndex = 5;
            txtNuevaContrasena.UseSystemPasswordChar = true;
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.AutoSize = true;
            lblConfirmarContrasena.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmarContrasena.ForeColor = Color.DarkBlue;
            lblConfirmarContrasena.Location = new Point(245, 259);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(178, 23);
            lblConfirmarContrasena.TabIndex = 6;
            lblConfirmarContrasena.Text = "Confirmar Contraseña";
            lblConfirmarContrasena.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.DarkBlue;
            btnConfirmar.Location = new Point(264, 379);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(150, 40);
            btnConfirmar.TabIndex = 25;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.ForeColor = Color.DarkBlue;
            txtConfirmarContrasena.Location = new Point(186, 303);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.PasswordChar = '*';
            txtConfirmarContrasena.Size = new Size(300, 27);
            txtConfirmarContrasena.TabIndex = 15;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            // 
            // frmCambioContrasena
            // 
            AcceptButton = btnConfirmar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 493);
            ControlBox = false;
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(btnConfirmar);
            Controls.Add(lblConfirmarContrasena);
            Controls.Add(txtNuevaContrasena);
            Controls.Add(lblNuevaContrasena);
            Controls.Add(lblTituloCContraseña);
            Controls.Add(lblMensaje);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCambioContrasena";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FEXI-Cambio de Contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Label lblTituloCContraseña;
        private Label lblNuevaContrasena;
        private TextBox txtNuevaContrasena;
        private Label lblConfirmarContrasena;
        private Button btnConfirmar;
        private TextBox txtConfirmarContrasena;
    }
}