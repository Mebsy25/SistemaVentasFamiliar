using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace SistemaVentas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
          
            Usuario user = new NegocioUser().Listar().Where(u => u.Documento == txtDocumento.Text && u.Clave == txtContraseña.Text).FirstOrDefault();

            if (user != null)
            {
                Inicio form = new Inicio(user);
                form.Show();
                this.Hide();
                form.FormClosing += frm_cerrar;
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas.", "Error al Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
         private void frm_cerrar(object sender, FormClosingEventArgs e) { 
            txtDocumento.Clear();
            txtContraseña.Clear();
           

            this.Show();
        }
    }
}
