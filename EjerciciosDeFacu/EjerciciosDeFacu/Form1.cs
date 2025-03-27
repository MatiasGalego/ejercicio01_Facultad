using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosDeFacu
{
    public partial class Form1 : Form
    {
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;  // Aquí cambias el nombre
            string contraseña = txtContraseña.Text;  // Aquí también

            // Validación simple
            if (usuario == "admin" && contraseña == "1234")
            {
                MessageBox.Show($"¡Bienvenido {usuario}!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
