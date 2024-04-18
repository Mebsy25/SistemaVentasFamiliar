namespace SistemaVentas
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.MenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.MenuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.subCatego = new FontAwesome.Sharp.IconMenuItem();
            this.subProducto = new FontAwesome.Sharp.IconMenuItem();
            this.submenunegocio = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.SubVentas = new FontAwesome.Sharp.IconMenuItem();
            this.detalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.MenuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.SubCompras = new FontAwesome.Sharp.IconMenuItem();
            this.detallesCompra = new FontAwesome.Sharp.IconMenuItem();
            this.MenuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.submenuReporteCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuReporteVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.txtNombreUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuarios,
            this.MenuMantenedor,
            this.MenuVentas,
            this.MenuCompras,
            this.MenuClientes,
            this.MenuProveedores,
            this.MenuReportes,
            this.MenuAcercaDe});
            this.menu.Location = new System.Drawing.Point(0, 89);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1543, 78);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip3";
            // 
            // MenuUsuarios
            // 
            this.MenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.MenuUsuarios.IconColor = System.Drawing.Color.Black;
            this.MenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUsuarios.IconSize = 50;
            this.MenuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuarios.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(73, 74);
            this.MenuUsuarios.Text = "Usuario";
            this.MenuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuUsuarios.Click += new System.EventHandler(this.MenuUsuario_Click);
            // 
            // MenuMantenedor
            // 
            this.MenuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subCatego,
            this.subProducto,
            this.submenunegocio});
            this.MenuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.MenuMantenedor.IconColor = System.Drawing.Color.Black;
            this.MenuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuMantenedor.IconSize = 50;
            this.MenuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuMantenedor.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.MenuMantenedor.Name = "MenuMantenedor";
            this.MenuMantenedor.Size = new System.Drawing.Size(104, 74);
            this.MenuMantenedor.Text = "Mantenedor";
            this.MenuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subCatego
            // 
            this.subCatego.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subCatego.IconColor = System.Drawing.Color.Black;
            this.subCatego.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subCatego.Name = "subCatego";
            this.subCatego.Size = new System.Drawing.Size(157, 26);
            this.subCatego.Text = "Categoria";
            this.subCatego.Click += new System.EventHandler(this.subCatego_Click);
            // 
            // subProducto
            // 
            this.subProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subProducto.IconColor = System.Drawing.Color.Black;
            this.subProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subProducto.Name = "subProducto";
            this.subProducto.Size = new System.Drawing.Size(157, 26);
            this.subProducto.Text = "Producto";
            this.subProducto.Click += new System.EventHandler(this.subProducto_Click);
            // 
            // submenunegocio
            // 
            this.submenunegocio.Name = "submenunegocio";
            this.submenunegocio.Size = new System.Drawing.Size(157, 26);
            this.submenunegocio.Text = "Negocio";
            this.submenunegocio.Click += new System.EventHandler(this.submenunegocio_Click);
            // 
            // MenuVentas
            // 
            this.MenuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubVentas,
            this.detalleVenta});
            this.MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.MenuVentas.IconColor = System.Drawing.Color.Black;
            this.MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVentas.IconSize = 50;
            this.MenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVentas.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.MenuVentas.Name = "MenuVentas";
            this.MenuVentas.Size = new System.Drawing.Size(66, 74);
            this.MenuVentas.Text = "Ventas";
            this.MenuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubVentas
            // 
            this.SubVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubVentas.IconColor = System.Drawing.Color.Black;
            this.SubVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubVentas.Name = "SubVentas";
            this.SubVentas.Size = new System.Drawing.Size(171, 26);
            this.SubVentas.Text = "Ventas";
            this.SubVentas.Click += new System.EventHandler(this.SubVentas_Click);
            // 
            // detalleVenta
            // 
            this.detalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.detalleVenta.IconColor = System.Drawing.Color.Black;
            this.detalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.detalleVenta.Name = "detalleVenta";
            this.detalleVenta.Size = new System.Drawing.Size(171, 26);
            this.detalleVenta.Text = "Ver Detalles";
            this.detalleVenta.Click += new System.EventHandler(this.detalleVenta_Click);
            // 
            // MenuCompras
            // 
            this.MenuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubCompras,
            this.detallesCompra});
            this.MenuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.MenuCompras.IconColor = System.Drawing.Color.Black;
            this.MenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuCompras.IconSize = 50;
            this.MenuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuCompras.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.MenuCompras.Name = "MenuCompras";
            this.MenuCompras.Size = new System.Drawing.Size(82, 74);
            this.MenuCompras.Text = "Compras";
            this.MenuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubCompras
            // 
            this.SubCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubCompras.IconColor = System.Drawing.Color.Black;
            this.SubCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubCompras.Name = "SubCompras";
            this.SubCompras.Size = new System.Drawing.Size(171, 26);
            this.SubCompras.Text = "Compras";
            this.SubCompras.Click += new System.EventHandler(this.SubCompras_Click);
            // 
            // detallesCompra
            // 
            this.detallesCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.detallesCompra.IconColor = System.Drawing.Color.Black;
            this.detallesCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.detallesCompra.Name = "detallesCompra";
            this.detallesCompra.Size = new System.Drawing.Size(171, 26);
            this.detallesCompra.Text = "Ver Detalles";
            this.detallesCompra.Click += new System.EventHandler(this.detallesCompra_Click);
            // 
            // MenuClientes
            // 
            this.MenuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.MenuClientes.IconColor = System.Drawing.Color.Black;
            this.MenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuClientes.IconSize = 50;
            this.MenuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuClientes.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(75, 74);
            this.MenuClientes.Text = "Clientes";
            this.MenuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuClientes.Click += new System.EventHandler(this.MenuClientes_Click);
            // 
            // MenuProveedores
            // 
            this.MenuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.MenuProveedores.IconColor = System.Drawing.Color.Black;
            this.MenuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuProveedores.IconSize = 50;
            this.MenuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProveedores.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.MenuProveedores.Name = "MenuProveedores";
            this.MenuProveedores.Size = new System.Drawing.Size(105, 74);
            this.MenuProveedores.Text = "Proveedores";
            this.MenuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuProveedores.Click += new System.EventHandler(this.MenuProveedores_Click);
            // 
            // MenuReportes
            // 
            this.MenuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuReporteCompra,
            this.submenuReporteVentas});
            this.MenuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.MenuReportes.IconColor = System.Drawing.Color.Black;
            this.MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReportes.IconSize = 50;
            this.MenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReportes.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(82, 74);
            this.MenuReportes.Text = "Reportes";
            this.MenuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuReporteCompra
            // 
            this.submenuReporteCompra.Name = "submenuReporteCompra";
            this.submenuReporteCompra.Size = new System.Drawing.Size(208, 26);
            this.submenuReporteCompra.Text = "Reporte Compras";
            this.submenuReporteCompra.Click += new System.EventHandler(this.submenuReporteCompra_Click);
            // 
            // submenuReporteVentas
            // 
            this.submenuReporteVentas.Name = "submenuReporteVentas";
            this.submenuReporteVentas.Size = new System.Drawing.Size(208, 26);
            this.submenuReporteVentas.Text = "Reporte Ventas";
            this.submenuReporteVentas.Click += new System.EventHandler(this.submenuReporteVentas_Click);
            // 
            // MenuAcercaDe
            // 
            this.MenuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.MenuAcercaDe.IconColor = System.Drawing.Color.Black;
            this.MenuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuAcercaDe.IconSize = 50;
            this.MenuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuAcercaDe.Name = "MenuAcercaDe";
            this.MenuAcercaDe.Size = new System.Drawing.Size(89, 74);
            this.MenuAcercaDe.Text = "Acerca de";
            this.MenuAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuAcercaDe.Click += new System.EventHandler(this.MenuReportes_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.Crimson;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1543, 89);
            this.menuTitulo.TabIndex = 3;
            this.menuTitulo.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistema de Ventas";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 167);
            this.Contenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1543, 629);
            this.Contenedor.TabIndex = 16;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Crimson;
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnsalir.IconColor = System.Drawing.Color.White;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.IconSize = 52;
            this.btnsalir.Location = new System.Drawing.Point(1448, 15);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.btnsalir.Size = new System.Drawing.Size(79, 63);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtNombreUser
            // 
            this.txtNombreUser.AutoSize = true;
            this.txtNombreUser.BackColor = System.Drawing.Color.Crimson;
            this.txtNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUser.ForeColor = System.Drawing.Color.White;
            this.txtNombreUser.Location = new System.Drawing.Point(1185, 38);
            this.txtNombreUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNombreUser.Name = "txtNombreUser";
            this.txtNombreUser.Size = new System.Drawing.Size(71, 18);
            this.txtNombreUser.TabIndex = 18;
            this.txtNombreUser.Text = "lblusuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Crimson;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1116, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Usuario:";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 796);
            this.Controls.Add(this.txtNombreUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem MenuUsuarios;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuCompras;
        private FontAwesome.Sharp.IconMenuItem MenuClientes;
        private FontAwesome.Sharp.IconMenuItem MenuProveedores;
        private FontAwesome.Sharp.IconMenuItem MenuAcercaDe;
        private FontAwesome.Sharp.IconMenuItem MenuMantenedor;
        private FontAwesome.Sharp.IconMenuItem subCatego;
        private FontAwesome.Sharp.IconMenuItem subProducto;
        private System.Windows.Forms.Panel Contenedor;
        private FontAwesome.Sharp.IconMenuItem SubVentas;
        private FontAwesome.Sharp.IconMenuItem detalleVenta;
        private FontAwesome.Sharp.IconMenuItem SubCompras;
        private FontAwesome.Sharp.IconMenuItem detallesCompra;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private System.Windows.Forms.ToolStripMenuItem submenunegocio;
        private FontAwesome.Sharp.IconButton btnsalir;
        private System.Windows.Forms.Label txtNombreUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem submenuReporteCompra;
        private System.Windows.Forms.ToolStripMenuItem submenuReporteVentas;
    }
}

