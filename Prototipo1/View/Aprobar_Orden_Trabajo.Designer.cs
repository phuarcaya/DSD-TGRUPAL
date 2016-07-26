namespace Prototipo1.View
{
    partial class Aprobar_Orden_Trabajo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListados = new System.Windows.Forms.DataGridView();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnDesaprobar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TabLista.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.PanelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListados)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.PanelTitulo.Size = new System.Drawing.Size(834, 42);
            // 
            // TabLista
            // 
            this.TabLista.Location = new System.Drawing.Point(0, 117);
            this.TabLista.Margin = new System.Windows.Forms.Padding(4);
            this.TabLista.Size = new System.Drawing.Size(822, 390);
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.dgvListados);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage1.Size = new System.Drawing.Size(814, 363);
            this.TabPage1.Controls.SetChildIndex(this.dgvListados, 0);
            // 
            // PanelCabecera
            // 
            this.PanelCabecera.Controls.Add(this.btnDesaprobar);
            this.PanelCabecera.Controls.Add(this.btnAprobar);
            this.PanelCabecera.Controls.Add(this.cboEstado);
            this.PanelCabecera.Controls.Add(this.label2);
            this.PanelCabecera.Controls.Add(this.dtpFechaFinal);
            this.PanelCabecera.Controls.Add(this.dtpFechaInicio);
            this.PanelCabecera.Controls.Add(this.label1);
            this.PanelCabecera.Location = new System.Drawing.Point(0, 42);
            this.PanelCabecera.Margin = new System.Windows.Forms.Padding(4);
            this.PanelCabecera.Size = new System.Drawing.Size(834, 69);
            // 
            // dgvListados
            // 
            this.dgvListados.AllowUserToAddRows = false;
            this.dgvListados.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvListados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvListados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column2,
            this.Column4,
            this.Sel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListados.EnableHeadersVisualStyles = false;
            this.dgvListados.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvListados.Location = new System.Drawing.Point(4, 4);
            this.dgvListados.Name = "dgvListados";
            this.dgvListados.RowHeadersVisible = false;
            this.dgvListados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListados.Size = new System.Drawing.Size(806, 330);
            this.dgvListados.TabIndex = 37;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Location = new System.Drawing.Point(79, 40);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(340, 21);
            this.cboEstado.TabIndex = 49;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Estado:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(79, 14);
            this.dtpFechaInicio.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpFechaInicio.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaInicio.TabIndex = 48;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Fecha OT:";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(206, 14);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaFinal.TabIndex = 48;
            this.dtpFechaFinal.ValueChanged += new System.EventHandler(this.dtpFechaFinal_ValueChanged);
            // 
            // btnAprobar
            // 
            this.btnAprobar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobar.ForeColor = System.Drawing.Color.Olive;
            this.btnAprobar.Location = new System.Drawing.Point(556, 29);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(130, 32);
            this.btnAprobar.TabIndex = 51;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnDesaprobar
            // 
            this.btnDesaprobar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesaprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesaprobar.ForeColor = System.Drawing.Color.Olive;
            this.btnDesaprobar.Location = new System.Drawing.Point(692, 29);
            this.btnDesaprobar.Name = "btnDesaprobar";
            this.btnDesaprobar.Size = new System.Drawing.Size(130, 32);
            this.btnDesaprobar.TabIndex = 51;
            this.btnDesaprobar.Text = "Desaprobar";
            this.btnDesaprobar.UseVisualStyleBackColor = true;
            this.btnDesaprobar.Click += new System.EventHandler(this.btnDesaprobar_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Número";
            this.Id.Name = "Id";
            this.Id.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Fecha";
            this.Column2.HeaderText = "Fecha Generación";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Estado";
            this.Column4.HeaderText = "Estado";
            this.Column4.Name = "Column4";
            this.Column4.Width = 300;
            // 
            // Sel
            // 
            this.Sel.HeaderText = "Sel";
            this.Sel.Name = "Sel";
            this.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Aprobar_Orden_Trabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Aprobar_Orden_Trabajo";
            this.Text = "Aprobacion de Orden de Trabajo";
            this.Load += new System.EventHandler(this.Aprobar_Orden_Trabajo_Load);
            this.TabLista.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.PanelCabecera.ResumeLayout(false);
            this.PanelCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvListados;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnDesaprobar;
        public System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;

    }
}