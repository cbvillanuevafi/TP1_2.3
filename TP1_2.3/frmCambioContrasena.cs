using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_2._3
{
    public partial class frmCambioContrasena : Form
    {
        public frmCambioContrasena()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNuevaContrasena.Text.Trim() == "" || txtConfirmarContrasena.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar ambos campos.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNuevaContrasena.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNuevaContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // me falta donde guardar el cambio de  contraseña, supongo debo esperar el frmregistro?

            //MessageBox.Show("La contraseña se guardó correctamente.");
        }
    }
}
