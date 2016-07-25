namespace Prototipo1.View
{
    partial class MovimientoAlmacen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboAlmacen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOt = new System.Windows.Forms.TextBox();
            this.lklAgregar = new System.Windows.Forms.LinkLabel();
            this.TabPageRegistro.SuspendLayout();
            this.TabPageListado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TabControlMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.PanelTitulo.Size = new System.Drawing.Size(834, 41);
            // 
            // panel1
            // 
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            // 
            // TabPageRegistro
            // 
            this.TabPageRegistro.Controls.Add(this.lklAgregar);
            this.TabPageRegistro.Controls.Add(this.cboAlmacen);
            this.TabPageRegistro.Controls.Add(this.label2);
            this.TabPageRegistro.Controls.Add(this.dtpFecha);
            this.TabPageRegistro.Controls.Add(this.txtOt);
            this.TabPageRegistro.Controls.Add(this.txtNumero);
            this.TabPageRegistro.Controls.Add(this.label3);
            this.TabPageRegistro.Controls.Add(this.label1);
            this.TabPageRegistro.Controls.Add(this.label15);
            this.TabPageRegistro.Controls.Add(this.dgvMovimientos);
            this.TabPageRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageRegistro.Padding = new System.Windows.Forms.Padding(4);
            this.TabPageRegistro.Size = new System.Drawing.Size(785, 386);
            // 
            // TabPageListado
            // 
            this.TabPageListado.Controls.Add(this.dgvListados);
            this.TabPageListado.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageListado.Padding = new System.Windows.Forms.Padding(4);
            this.TabPageListado.Size = new System.Drawing.Size(785, 386);
            this.TabPageListado.Controls.SetChildIndex(this.groupBox1, 0);
            this.TabPageListado.Controls.SetChildIndex(this.dgvListados, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(778, 51);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(695, 14);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // TabControlMantenimiento
            // 
            this.TabControlMantenimiento.Margin = new System.Windows.Forms.Padding(4);
            this.TabControlMantenimiento.Size = new System.Drawing.Size(793, 412);
            // 
            // dgvListados
            // 
            this.dgvListados.AllowUserToAddRows = false;
            this.dgvListados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListados.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvListados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvListados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvListados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListados.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvListados.EnableHeadersVisualStyles = false;
            this.dgvListados.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvListados.Location = new System.Drawing.Point(2, 58);
            this.dgvListados.Name = "dgvListados";
            this.dgvListados.RowHeadersVisible = false;
            this.dgvListados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListados.Size = new System.Drawing.Size(779, 338);
            this.dgvListados.TabIndex = 36;
            this.dgvListados.SelectionChanged += new System.EventHandler(this.dgvListados_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Número";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Almacen";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "N° OT";
            this.Column5.Name = "Column5";
            // 
            // cboAlmacen
            // 
            this.cboAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlmacen.Location = new System.Drawing.Point(427, 11);
            this.cboAlmacen.Name = "cboAlmacen";
            this.cboAlmacen.Size = new System.Drawing.Size(340, 21);
            this.cboAlmacen.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Almacen:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(58, 42);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(150, 20);
            this.dtpFecha.TabIndex = 49;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(58, 14);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(150, 20);
            this.txtNumero.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Número:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 47;
            this.label15.Text = "Número:";
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.AllowUserToAddRows = false;
            this.dgvMovimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovimientos.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column13,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column3,
            this.DEL});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovimientos.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvMovimientos.EnableHeadersVisualStyles = false;
            this.dgvMovimientos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMovimientos.Location = new System.Drawing.Point(5, 68);
            this.dgvMovimientos.Name = "dgvMovimientos";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvMovimientos.RowHeadersWidth = 40;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dgvMovimientos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvMovimientos.Size = new System.Drawing.Size(774, 308);
            this.dgvMovimientos.TabIndex = 45;
            this.dgvMovimientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimientos_CellClick);
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "IdClienteEmpresa";
            this.Column11.HeaderText = "N°";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 60;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "NroDocumentoIdentidad";
            this.Column13.HeaderText = "Código";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Digito";
            this.dataGridViewTextBoxColumn1.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stock";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // DEL
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DEL.DefaultCellStyle = dataGridViewCellStyle9;
            this.DEL.HeaderText = "Eliminar";
            this.DEL.LinkColor = System.Drawing.Color.SteelBlue;
            this.DEL.Name = "DEL";
            this.DEL.Text = "Eliminar";
            this.DEL.ToolTipText = "Eliminar Registro";
            this.DEL.UseColumnTextForLinkValue = true;
            this.DEL.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.DEL.Width = 70;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Orden Trabajo:";
            // 
            // txtOt
            // 
            this.txtOt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOt.Location = new System.Drawing.Point(427, 42);
            this.txtOt.Name = "txtOt";
            this.txtOt.Size = new System.Drawing.Size(174, 20);
            this.txtOt.TabIndex = 48;
            // 
            // lklAgregar
            // 
            this.lklAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lklAgregar.AutoSize = true;
            this.lklAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklAgregar.LinkColor = System.Drawing.Color.Maroon;
            this.lklAgregar.Location = new System.Drawing.Point(607, 45);
            this.lklAgregar.Name = "lklAgregar";
            this.lklAgregar.Size = new System.Drawing.Size(65, 15);
            this.lklAgregar.TabIndex = 52;
            this.lklAgregar.TabStop = true;
            this.lklAgregar.Text = "Agregar(+)";
            this.lklAgregar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklAgregar_LinkClicked);
            // 
            // Movimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Movimiento";
            this.Text = "";
            this.Load += new System.EventHandler(this.IngresoProducto_Load);
            this.TabPageRegistro.ResumeLayout(false);
            this.TabPageRegistro.PerformLayout();
            this.TabPageListado.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.TabControlMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvListados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cboAlmacen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtOt;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewLinkColumn DEL;
        private System.Windows.Forms.LinkLabel lklAgregar;

    }
}