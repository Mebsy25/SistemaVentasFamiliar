using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FontAwesome.Sharp;
using CapaNegocio;
using SistemaVentas.Modales;

namespace SistemaVentas
{
    public partial class Inicio : Form
    {
        private static Usuario Nombre;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio(Usuario name)
        {
            InitializeComponent();
            Nombre = name;
        }

        private void MenuUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuario());
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new NegocioPermiso().Listar(Nombre.IdUsuario);
            
            foreach(IconMenuItem iconMenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconMenu.Name);
                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }

           txtNombreUser.Text = Nombre.NombreCompleto;
        }

        private void AbrirFormulario(IconMenuItem menu, Form Formulario)
        {
            if(MenuActivo != null) { 
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = Formulario;
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle= FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            Formulario.BackColor = Color.Crimson;

            Contenedor.Controls.Add(Formulario);
            Formulario.Show();
        }

        private void subCatego_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuMantenedor, new frmCategoria());

        }

        private void subProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuMantenedor, new frmProducto());

        }

        private void SubVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new frmVentas(Nombre));

        }

        private void SubCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new frmCompras(Nombre));

        }

        private void MenuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void MenuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void MenuReportes_Click(object sender, EventArgs e)
        {
            mdAcercade md = new mdAcercade();
            md.ShowDialog();
        }

        private void submenunegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuMantenedor, new frmNegocio());

        }

        private void detallesCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new frmDetalleCompra());

        }

        private void detalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new frmDetalleVenta());

        }

        private void submenuReporteCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuReportes, new frmReporteCompras());

        }

        private void submenuReporteVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuReportes, new frmReporteVentas());

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
