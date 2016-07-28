namespace Prototipo1.View
{
    partial class frmMantenimiento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimiento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.BindingNavigatorListado = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMantenimiento = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGrabar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnDeshacer = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLista = new System.Windows.Forms.ToolStripButton();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.TabPageRegistro = new System.Windows.Forms.TabPage();
            this.TabPageListado = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.TabControlMantenimiento = new System.Windows.Forms.TabControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorListado)).BeginInit();
            this.BindingNavigatorListado.SuspendLayout();
            this.toolMantenimiento.SuspendLayout();
            this.TabPageListado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TabControlMantenimiento.SuspendLayout();
            this.PanelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 24);
            this.panel1.TabIndex = 16;
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.White;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(4, 6);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(13, 15);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "*";
            // 
            // BindingNavigatorListado
            // 
            this.BindingNavigatorListado.AddNewItem = null;
            this.BindingNavigatorListado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BindingNavigatorListado.CountItem = this.bindingNavigatorCountItem;
            this.BindingNavigatorListado.CountItemFormat = "de {0}";
            this.BindingNavigatorListado.DeleteItem = null;
            this.BindingNavigatorListado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BindingNavigatorListado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.BindingNavigatorListado.Location = new System.Drawing.Point(0, 468);
            this.BindingNavigatorListado.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindingNavigatorListado.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindingNavigatorListado.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindingNavigatorListado.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindingNavigatorListado.Name = "BindingNavigatorListado";
            this.BindingNavigatorListado.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavigatorListado.Size = new System.Drawing.Size(844, 25);
            this.BindingNavigatorListado.TabIndex = 18;
            this.BindingNavigatorListado.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::Prototipo1.Properties.Resources.primero;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.ToolTipText = "Ir al principio";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::Prototipo1.Properties.Resources.anterior;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.ToolTipText = "Anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::Prototipo1.Properties.Resources.siguiente;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.ToolTipText = "Siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::Prototipo1.Properties.Resources.ultimo;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.ToolTipText = "Ir al último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolMantenimiento
            // 
            this.toolMantenimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolMantenimiento.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolMantenimiento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolMantenimiento.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolMantenimiento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGrabar,
            this.btnModificar,
            this.btnDeshacer,
            this.btnEliminar,
            this.toolStripSeparator4,
            this.btnLista,
            this.btnCerrar});
            this.toolMantenimiento.Location = new System.Drawing.Point(806, 47);
            this.toolMantenimiento.Name = "toolMantenimiento";
            this.toolMantenimiento.Size = new System.Drawing.Size(38, 421);
            this.toolMantenimiento.Stretch = true;
            this.toolMantenimiento.TabIndex = 22;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(35, 46);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.ToolTipText = "Nuevo ( Ctrl N )";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(35, 50);
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGrabar.ToolTipText = "Grabar ( Ctrl G )";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(35, 63);
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificar.ToolTipText = "Modificar ( Ctrl M )";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeshacer.Image")));
            this.btnDeshacer.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(35, 60);
            this.btnDeshacer.Text = "&Cancelar";
            this.btnDeshacer.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.btnDeshacer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeshacer.ToolTipText = "Deshacer ( Ctrl D )";
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(35, 56);
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.ToolTipText = "Eliminar ( Ctrl E )";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(35, 6);
            // 
            // btnLista
            // 
            this.btnLista.Image = global::Prototipo1.Properties.Resources.List;
            this.btnLista.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(35, 52);
            this.btnLista.Text = "&Listado";
            this.btnLista.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.btnLista.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLista.ToolTipText = "Ir a la lista";
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 47);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCerrar.ToolTipText = "Cerrar Ventana";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // TabPageRegistro
            // 
            this.TabPageRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabPageRegistro.Location = new System.Drawing.Point(4, 22);
            this.TabPageRegistro.Name = "TabPageRegistro";
            this.TabPageRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageRegistro.Size = new System.Drawing.Size(799, 394);
            this.TabPageRegistro.TabIndex = 1;
            this.TabPageRegistro.Text = "Registro";
            this.TabPageRegistro.UseVisualStyleBackColor = true;
            // 
            // TabPageListado
            // 
            this.TabPageListado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabPageListado.Controls.Add(this.groupBox1);
            this.TabPageListado.Location = new System.Drawing.Point(4, 22);
            this.TabPageListado.Name = "TabPageListado";
            this.TabPageListado.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageListado.Size = new System.Drawing.Size(799, 394);
            this.TabPageListado.TabIndex = 0;
            this.TabPageListado.Text = "Listado";
            this.TabPageListado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRefrescar);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.Color.Olive;
            this.btnRefrescar.Image = global::Prototipo1.Properties.Resources.Refresh;
            this.btnRefrescar.Location = new System.Drawing.Point(708, 13);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(79, 32);
            this.btnRefrescar.TabIndex = 0;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // TabControlMantenimiento
            // 
            this.TabControlMantenimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlMantenimiento.Controls.Add(this.TabPageListado);
            this.TabControlMantenimiento.Controls.Add(this.TabPageRegistro);
            this.TabControlMantenimiento.Location = new System.Drawing.Point(0, 47);
            this.TabControlMantenimiento.Name = "TabControlMantenimiento";
            this.TabControlMantenimiento.SelectedIndex = 0;
            this.TabControlMantenimiento.Size = new System.Drawing.Size(807, 420);
            this.TabControlMantenimiento.TabIndex = 17;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "Mensaje";
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.Gray;
            this.PanelTitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelTitulo.BackgroundImage")));
            this.PanelTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelTitulo.Controls.Add(this.lblTitulo);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(844, 47);
            this.PanelTitulo.TabIndex = 15;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.lblTitulo.Location = new System.Drawing.Point(6, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(53, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo";
            // 
            // frmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 517);
            this.Controls.Add(this.toolMantenimiento);
            this.Controls.Add(this.BindingNavigatorListado);
            this.Controls.Add(this.TabControlMantenimiento);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimiento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorListado)).EndInit();
            this.BindingNavigatorListado.ResumeLayout(false);
            this.BindingNavigatorListado.PerformLayout();
            this.toolMantenimiento.ResumeLayout(false);
            this.toolMantenimiento.PerformLayout();
            this.TabPageListado.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.TabControlMantenimiento.ResumeLayout(false);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel PanelTitulo;
        protected System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.BindingNavigator BindingNavigatorListado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.TabPage TabPageRegistro;
        public System.Windows.Forms.TabPage TabPageListado;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnRefrescar;
        public System.Windows.Forms.TabControl TabControlMantenimiento;
        public System.Windows.Forms.ToolStrip toolMantenimiento;
        public System.Windows.Forms.ToolStripButton btnNuevo;
        public System.Windows.Forms.ToolStripButton btnGrabar;
        public System.Windows.Forms.ToolStripButton btnModificar;
        public System.Windows.Forms.ToolStripButton btnDeshacer;
        public System.Windows.Forms.ToolStripButton btnEliminar;
        public System.Windows.Forms.ToolStripButton btnCerrar;
        public System.Windows.Forms.ToolStripButton btnLista;
        protected System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Label lblTitulo;
    }
}