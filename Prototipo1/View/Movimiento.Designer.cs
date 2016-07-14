namespace Prototipo1.View
{
    partial class Movimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNomreRazonSocialSerah = new System.Windows.Forms.TextBox();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.PanelTitulo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PanelTitulo.Size = new System.Drawing.Size(1112, 50);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 599);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(1112, 30);
            // 
            // TabPageRegistro
            // 
            this.TabPageRegistro.Controls.Add(this.cboMes);
            this.TabPageRegistro.Controls.Add(this.label2);
            this.TabPageRegistro.Controls.Add(this.dateTimePicker1);
            this.TabPageRegistro.Controls.Add(this.textBox1);
            this.TabPageRegistro.Controls.Add(this.txtNomreRazonSocialSerah);
            this.TabPageRegistro.Controls.Add(this.label3);
            this.TabPageRegistro.Controls.Add(this.label1);
            this.TabPageRegistro.Controls.Add(this.label15);
            this.TabPageRegistro.Controls.Add(this.dgvMovimientos);
            this.TabPageRegistro.Location = new System.Drawing.Point(4, 25);
            this.TabPageRegistro.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TabPageRegistro.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TabPageRegistro.Size = new System.Drawing.Size(1049, 478);
            // 
            // TabPageListado
            // 
            this.TabPageListado.Controls.Add(this.dgvListados);
            this.TabPageListado.Location = new System.Drawing.Point(4, 25);
            this.TabPageListado.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TabPageListado.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TabPageListado.Size = new System.Drawing.Size(1049, 478);
            this.TabPageListado.Controls.SetChildIndex(this.groupBox1, 0);
            this.TabPageListado.Controls.SetChildIndex(this.dgvListados, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(1012, 63);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(921, 16);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // TabControlMantenimiento
            // 
            this.TabControlMantenimiento.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TabControlMantenimiento.Size = new System.Drawing.Size(1057, 507);
            // 
            // dgvListados
            // 
            this.dgvListados.AllowUserToAddRows = false;
            this.dgvListados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListados.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvListados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvListados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListados.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListados.EnableHeadersVisualStyles = false;
            this.dgvListados.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvListados.Location = new System.Drawing.Point(3, 71);
            this.dgvListados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListados.Name = "dgvListados";
            this.dgvListados.RowHeadersVisible = false;
            this.dgvListados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListados.Size = new System.Drawing.Size(875, 306);
            this.dgvListados.TabIndex = 36;
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
            // cboMes
            // 
            this.cboMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.Location = new System.Drawing.Point(569, 14);
            this.cboMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(452, 24);
            this.cboMes.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Almacen:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 52);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 22);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // txtNomreRazonSocialSerah
            // 
            this.txtNomreRazonSocialSerah.Location = new System.Drawing.Point(77, 17);
            this.txtNomreRazonSocialSerah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomreRazonSocialSerah.Name = "txtNomreRazonSocialSerah";
            this.txtNomreRazonSocialSerah.Size = new System.Drawing.Size(199, 22);
            this.txtNomreRazonSocialSerah.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Número:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 17);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 17);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column13,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column3,
            this.DEL});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovimientos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMovimientos.EnableHeadersVisualStyles = false;
            this.dgvMovimientos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMovimientos.Location = new System.Drawing.Point(7, 84);
            this.dgvMovimientos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMovimientos.Name = "dgvMovimientos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMovimientos.RowHeadersWidth = 40;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dgvMovimientos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMovimientos.Size = new System.Drawing.Size(1032, 379);
            this.dgvMovimientos.TabIndex = 45;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DEL.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.label3.Location = new System.Drawing.Point(468, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Orden Trabajo:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(569, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 22);
            this.textBox1.TabIndex = 48;
            // 
            // Movimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 629);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNomreRazonSocialSerah;
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

    }
}