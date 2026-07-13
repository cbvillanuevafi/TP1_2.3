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
            lblNombreRecu = new Label();
            lblNombreusuario = new Label();
            txtNombreusuario = new TextBox();
            txtContraseñanueva = new TextBox();
            lblContraseña1 = new Label();
            btnEnviarcodigo = new Button();
            label3 = new Label();
            lblmensaje = new Label();
            btnConfirmar = new Button();
            btnVolver = new Button();
            lblConfirmarcontraseña = new Label();
            txtConfirmarcontraseña = new TextBox();
            lblCodigoenviado = new Label();
            txtCodigoenviado = new TextBox();
            btnValidarcodigo = new Button();
            SuspendLayout();
            // 
            // lblNombreRecu
            // 
            lblNombreRecu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNombreRecu.AutoSize = true;
            lblNombreRecu.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreRecu.ForeColor = Color.DarkBlue;
            lblNombreRecu.Location = new Point(74, 12);
            lblNombreRecu.Name = "lblNombreRecu";
            lblNombreRecu.Size = new Size(370, 46);
            lblNombreRecu.TabIndex = 0;
            lblNombreRecu.Text = "Recuperar Contraseña";
            // 
            // lblNombreusuario
            // 
            lblNombreusuario.AutoSize = true;
            lblNombreusuario.ForeColor = Color.DarkBlue;
            lblNombreusuario.Location = new Point(14, 83);
            lblNombreusuario.Name = "lblNombreusuario";
            lblNombreusuario.Size = new Size(139, 20);
            lblNombreusuario.TabIndex = 1;
            lblNombreusuario.Text = "Nombre de Usuario";
            // 
            // txtNombreusuario
            // 
            txtNombreusuario.Cursor = Cursors.IBeam;
            txtNombreusuario.Location = new Point(14, 107);
            txtNombreusuario.Margin = new Padding(3, 4, 3, 4);
            txtNombreusuario.Name = "txtNombreusuario";
            txtNombreusuario.Size = new Size(245, 27);
            txtNombreusuario.TabIndex = 2;
            // 
            // txtContraseñanueva
            // 
            txtContraseñanueva.Cursor = Cursors.IBeam;
            txtContraseñanueva.Enabled = false;
            txtContraseñanueva.Location = new Point(14, 320);
            txtContraseñanueva.Margin = new Padding(3, 4, 3, 4);
            txtContraseñanueva.Name = "txtContraseñanueva";
            txtContraseñanueva.PasswordChar = '*';
            txtContraseñanueva.Size = new Size(245, 27);
            txtContraseñanueva.TabIndex = 18;
            // 
            // lblContraseña1
            // 
            lblContraseña1.AutoSize = true;
            lblContraseña1.ForeColor = Color.DarkBlue;
            lblContraseña1.Location = new Point(14, 296);
            lblContraseña1.Name = "lblContraseña1";
            lblContraseña1.Size = new Size(127, 20);
            lblContraseña1.TabIndex = 3;
            lblContraseña1.Text = "Nueva contraseña";
            // 
            // btnEnviarcodigo
            // 
            btnEnviarcodigo.BackColor = Color.RoyalBlue;
            btnEnviarcodigo.Cursor = Cursors.Hand;
            btnEnviarcodigo.ForeColor = Color.Black;
            btnEnviarcodigo.Location = new Point(14, 145);
            btnEnviarcodigo.Margin = new Padding(3, 4, 3, 4);
            btnEnviarcodigo.Name = "btnEnviarcodigo";
            btnEnviarcodigo.Size = new Size(246, 37);
            btnEnviarcodigo.TabIndex = 5;
            btnEnviarcodigo.Text = "Enviar código";
            btnEnviarcodigo.UseVisualStyleBackColor = false;
            btnEnviarcodigo.Click += btnEnviarcodigo_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(265, 173);
            label3.Name = "label3";
            label3.Size = new Size(255, 28);
            label3.TabIndex = 7;
            label3.Text = "¿Olvidaste tu contraseña?";
            // 
            // lblmensaje
            // 
            lblmensaje.AutoSize = true;
            lblmensaje.Location = new Point(296, 201);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(193, 100);
            lblmensaje.TabIndex = 8;
            lblmensaje.Text = "No te preocupes, podemos \r\nayudarte a reestablecerla. \r\nIngresá el usuario con el \r\ncual iniciaste sesión \r\nanteriormente.";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.Location = new Point(14, 439);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(246, 35);
            btnConfirmar.TabIndex = 22;
            btnConfirmar.Text = "Guardar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Location = new Point(282, 440);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(206, 35);
            btnVolver.TabIndex = 24;
            btnVolver.Text = "Volver al inicio de sesión";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // lblConfirmarcontraseña
            // 
            lblConfirmarcontraseña.AutoSize = true;
            lblConfirmarcontraseña.ForeColor = Color.DarkBlue;
            lblConfirmarcontraseña.Location = new Point(14, 355);
            lblConfirmarcontraseña.Name = "lblConfirmarcontraseña";
            lblConfirmarcontraseña.Size = new Size(151, 20);
            lblConfirmarcontraseña.TabIndex = 12;
            lblConfirmarcontraseña.Text = "Confirmar contraseña";
            // 
            // txtConfirmarcontraseña
            // 
            txtConfirmarcontraseña.Cursor = Cursors.IBeam;
            txtConfirmarcontraseña.Enabled = false;
            txtConfirmarcontraseña.Location = new Point(14, 379);
            txtConfirmarcontraseña.Margin = new Padding(3, 4, 3, 4);
            txtConfirmarcontraseña.Name = "txtConfirmarcontraseña";
            txtConfirmarcontraseña.PasswordChar = '*';
            txtConfirmarcontraseña.Size = new Size(245, 27);
            txtConfirmarcontraseña.TabIndex = 20;
            // 
            // lblCodigoenviado
            // 
            lblCodigoenviado.AutoSize = true;
            lblCodigoenviado.ForeColor = Color.DarkBlue;
            lblCodigoenviado.Location = new Point(74, 201);
            lblCodigoenviado.Name = "lblCodigoenviado";
            lblCodigoenviado.Size = new Size(115, 20);
            lblCodigoenviado.TabIndex = 14;
            lblCodigoenviado.Text = "Código enviado";
            // 
            // txtCodigoenviado
            // 
            txtCodigoenviado.Cursor = Cursors.IBeam;
            txtCodigoenviado.Enabled = false;
            txtCodigoenviado.Location = new Point(14, 225);
            txtCodigoenviado.Margin = new Padding(3, 4, 3, 4);
            txtCodigoenviado.Name = "txtCodigoenviado";
            txtCodigoenviado.PlaceholderText = "Ingrese el código recibido";
            txtCodigoenviado.Size = new Size(245, 27);
            txtCodigoenviado.TabIndex = 15;
            txtCodigoenviado.TextAlign = HorizontalAlignment.Center;
            // 
            // btnValidarcodigo
            // 
            btnValidarcodigo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnValidarcodigo.BackColor = SystemColors.ActiveCaption;
            btnValidarcodigo.Cursor = Cursors.Hand;
            btnValidarcodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidarcodigo.Location = new Point(14, 261);
            btnValidarcodigo.Margin = new Padding(3, 4, 3, 4);
            btnValidarcodigo.Name = "btnValidarcodigo";
            btnValidarcodigo.Size = new Size(246, 31);
            btnValidarcodigo.TabIndex = 16;
            btnValidarcodigo.Text = "Validar";
            btnValidarcodigo.UseVisualStyleBackColor = false;
            btnValidarcodigo.Click += btnValidarcodigo_Click;
            // 
            // frmRecuperarContrasena
            // 
            AcceptButton = btnConfirmar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnVolver;
            ClientSize = new Size(521, 491);
            Controls.Add(btnValidarcodigo);
            Controls.Add(txtCodigoenviado);
            Controls.Add(lblCodigoenviado);
            Controls.Add(txtConfirmarcontraseña);
            Controls.Add(lblConfirmarcontraseña);
            Controls.Add(btnVolver);
            Controls.Add(btnConfirmar);
            Controls.Add(lblmensaje);
            Controls.Add(label3);
            Controls.Add(btnEnviarcodigo);
            Controls.Add(txtContraseñanueva);
            Controls.Add(lblContraseña1);
            Controls.Add(txtNombreusuario);
            Controls.Add(lblNombreusuario);
            Controls.Add(lblNombreRecu);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRecuperarContrasena";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += frmRecuperarContrasena_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreRecu;
        private Label lblNombreusuario;
        private TextBox txtNombreusuario;
        private TextBox txtContraseñanueva;
        private Label lblContraseña1;
        private Button btnEnviarcodigo;
        private Label label3;
        private Label lblmensaje;
        private Button btnConfirmar;
        private Button btnVolver;
        private Label lblConfirmarcontraseña;
        private TextBox txtConfirmarcontraseña;
        private Label lblCodigoenviado;
        private TextBox txtCodigoenviado;
        private Button btnValidarcodigo;
    }
}