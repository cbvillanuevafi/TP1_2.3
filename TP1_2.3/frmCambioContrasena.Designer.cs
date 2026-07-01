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
            lblTitulo = new Label();
            lblMensaje = new Label();
            lblNuevaContrasena = new Label();
            txtNuevaContrasena = new TextBox();
            txtConfirmarContrasena = new TextBox();
            lblConfirmarContrasena = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(75, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(335, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cambio de Contraseña";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(62, 61);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(359, 25);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "Debe cambiar su contraseña para continuar.";
            // 
            // lblNuevaContrasena
            // 
            lblNuevaContrasena.AutoSize = true;
            lblNuevaContrasena.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNuevaContrasena.Location = new Point(159, 130);
            lblNuevaContrasena.Name = "lblNuevaContrasena";
            lblNuevaContrasena.Size = new Size(153, 25);
            lblNuevaContrasena.TabIndex = 2;
            lblNuevaContrasena.Text = "Nueva contraseña";
            // 
            // txtNuevaContrasena
            // 
            txtNuevaContrasena.Location = new Point(108, 158);
            txtNuevaContrasena.Name = "txtNuevaContrasena";
            txtNuevaContrasena.PasswordChar = '*';
            txtNuevaContrasena.Size = new Size(250, 27);
            txtNuevaContrasena.TabIndex = 3;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Location = new Point(108, 227);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.PasswordChar = '*';
            txtConfirmarContrasena.Size = new Size(250, 27);
            txtConfirmarContrasena.TabIndex = 5;
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.AutoSize = true;
            lblConfirmarContrasena.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmarContrasena.Location = new Point(144, 199);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(182, 25);
            lblConfirmarContrasena.TabIndex = 4;
            lblConfirmarContrasena.Text = "Confirmar contraseña";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(170, 292);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 40);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmCambioContrasena
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(482, 353);
            Controls.Add(btnGuardar);
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(lblConfirmarContrasena);
            Controls.Add(txtNuevaContrasena);
            Controls.Add(lblNuevaContrasena);
            Controls.Add(lblMensaje);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCambioContrasena";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FEXI - Cambio de Contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblMensaje;
        private Label lblNuevaContrasena;
        private TextBox txtNuevaContrasena;
        private TextBox txtConfirmarContrasena;
        private Label lblConfirmarContrasena;
        private Button btnGuardar;
    }
}