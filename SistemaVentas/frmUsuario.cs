using CapaEntidad;
using CapaNegocio;
using SistemaVentas.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new OpcionCombo(){Valor = 1 , Texto = "Activo"}); 
            cboEstado.Items.Add(new OpcionCombo(){Valor = 0 , Texto = "No Activo"}); 
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;

            List<Rol> listarol = new NegocioRol().Listar();
            foreach (Rol rol in listarol)
            {
                cboRol.Items.Add(new OpcionCombo() { Valor = rol.IdRol, Texto = rol.Descripcion });
            }
            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
            cboRol.SelectedIndex = 0;


            //MOSTRAR USUARIOS
            List<Usuario> listauser = new NegocioUser().Listar();

            foreach(Usuario user in listauser)
            {
                datagriduser.Rows.Add(new object[] {"",user.IdUsuario, user.Documento,user.NombreCompleto,user.Email, user.Clave,
                user.oRol.IdRol,
                user.oRol.Descripcion,
                user.Estado == true ? 1 : 0 , 
                user.Estado == true ? "Activo" : "No Activo",
            });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario usuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtID.Text),
                Documento = txtDocumento.Text,
                NombreCompleto = txtNombreC.Text,
                Email = txtCorreo.Text,
                Clave = txtClave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cboRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if(usuario.IdUsuario == 0)
            {
                int idusergen = new NegocioUser().Registrar(usuario, out mensaje);

                if (idusergen != 0)
                {
                    datagriduser.Rows.Add(new object[] {"",idusergen, txtDocumento.Text,txtNombreC.Text,txtCorreo.Text, txtClave,
                ((OpcionCombo)cboRol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cboRol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString(),
                });
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new NegocioUser().Editar(usuario, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = datagriduser.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value = txtID.Text;
                    row.Cells["Documento"].Value = txtDocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtNombreC.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Clave"].Value = txtClave.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)cboRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cboRol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtID.Text = "0";
            txtDocumento.Text = "";
            txtNombreC.Text = "";
            txtCorreo.Text = "";
            txtConfirmarClave.Text = "";
            txtClave.Text = "";
            cboRol.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;

            txtDocumento.Select();
        }

        private void datagriduser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagriduser.Columns[e.ColumnIndex].Name == "btnSeleccionar") {
                int indice = e.RowIndex;

                if(indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtID.Text = datagriduser.Rows[indice].Cells["Id"].Value.ToString();
                    txtDocumento.Text = datagriduser.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombreC.Text = datagriduser.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = datagriduser.Rows[indice].Cells["Correo"].Value.ToString();
                    txtClave.Text = datagriduser.Rows[indice].Cells["Clave"].Value.ToString();
                    txtConfirmarClave.Text = datagriduser.Rows[indice].Cells["Clave"].Value.ToString();

                    foreach(OpcionCombo oc in cboRol.Items)
                    {
                        if(Convert.ToInt32(oc.Valor)== Convert.ToInt32(datagriduser.Rows[indice].Cells["IdRol"].Value)) {
                            int indice_combo = cboRol.Items.IndexOf(oc);
                            cboRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    foreach (OpcionCombo oc in cboEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(datagriduser.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboEstado.Items.IndexOf(oc);
                            cboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario usuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtID.Text),
            };

            if (Convert.ToInt32(txtID.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el user?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool respuesta = new NegocioUser().Eliminar(usuario, out mensaje);

                    if (respuesta)
                    {
                        datagriduser.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    }
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
