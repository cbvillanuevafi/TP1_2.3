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
            lblMensaje.Location = new Point(97, 80);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(407, 19);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "\"Primer ingreso al Sistema. Cambie la Contraseña para continuar\"";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloCContraseña
            // 
            lblTituloCContraseña.AutoSize = true;
            lblTituloCContraseña.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloCContraseña.ForeColor = Color.DarkBlue;
            lblTituloCContraseña.Location = new Point(246, 25);
            lblTituloCContraseña.Name = "lblTituloCContraseña";
            lblTituloCContraseña.Size = new Size(81, 41);
            lblTituloCContraseña.TabIndex = 3;
            lblTituloCContraseña.Text = "FEXI";
            lblTituloCContraseña.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNuevaContrasena
            // 
            lblNuevaContrasena.AutoSize = true;
            lblNuevaContrasena.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNuevaContrasena.ForeColor = Color.DarkBlue;
            lblNuevaContrasena.Location = new Point(223, 121);
            lblNuevaContrasena.Name = "lblNuevaContrasena";
            lblNuevaContrasena.Size = new Size(122, 19);
            lblNuevaContrasena.TabIndex = 4;
            lblNuevaContrasena.Text = "Nueva Contraseña";
            lblNuevaContrasena.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNuevaContrasena
            // 
            txtNuevaContrasena.ForeColor = Color.DarkBlue;
            txtNuevaContrasena.Location = new Point(163, 156);
            txtNuevaContrasena.Margin = new Padding(3, 2, 3, 2);
            txtNuevaContrasena.Name = "txtNuevaContrasena";
            txtNuevaContrasena.Size = new Size(263, 23);
            txtNuevaContrasena.TabIndex = 5;
            txtNuevaContrasena.UseSystemPasswordChar = true;
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.AutoSize = true;
            lblConfirmarContrasena.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmarContrasena.ForeColor = Color.DarkBlue;
            lblConfirmarContrasena.Location = new Point(214, 194);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(144, 19);
            lblConfirmarContrasena.TabIndex = 6;
            lblConfirmarContrasena.Text = "Confirmar Contraseña";
            lblConfirmarContrasena.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.DarkBlue;
            btnConfirmar.Location = new Point(214, 284);
            btnConfirmar.Margin = new Padding(3, 2, 3, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(131, 30);
            btnConfirmar.TabIndex = 21;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.ForeColor = Color.DarkBlue;
            txtConfirmarContrasena.Location = new Point(163, 227);
            txtConfirmarContrasena.Margin = new Padding(3, 2, 3, 2);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.PasswordChar = '*';
            txtConfirmarContrasena.Size = new Size(263, 23);
            txtConfirmarContrasena.TabIndex = 22;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            // 
            // frmCambioContrasena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 370);
            ControlBox = false;
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(btnConfirmar);
            Controls.Add(lblConfirmarContrasena);
            Controls.Add(txtNuevaContrasena);
            Controls.Add(lblNuevaContrasena);
            Controls.Add(lblTituloCContraseña);
            Controls.Add(lblMensaje);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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