namespace Estirar_Sueldo
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpPatrimonio = new System.Windows.Forms.GroupBox();
            this.grpSueldo = new System.Windows.Forms.GroupBox();
            this.btnNuevoIngreso = new System.Windows.Forms.Button();
            this.txtNuevoIngreso = new System.Windows.Forms.TextBox();
            this.dgvDeudas = new System.Windows.Forms.DataGridView();
            this.grpDeudas = new System.Windows.Forms.GroupBox();
            this.grpPagos = new System.Windows.Forms.GroupBox();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.grpIngresos = new System.Windows.Forms.GroupBox();
            this.dgvIngresos = new System.Windows.Forms.DataGridView();
            this.grpExtracciones = new System.Windows.Forms.GroupBox();
            this.dgvExtracciones = new System.Windows.Forms.DataGridView();
            this.comboMesIngreso = new System.Windows.Forms.ComboBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.grpSueldo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).BeginInit();
            this.grpDeudas.SuspendLayout();
            this.grpPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.grpIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).BeginInit();
            this.grpExtracciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtracciones)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPatrimonio
            // 
            this.grpPatrimonio.Location = new System.Drawing.Point(22, 30);
            this.grpPatrimonio.Name = "grpPatrimonio";
            this.grpPatrimonio.Size = new System.Drawing.Size(620, 100);
            this.grpPatrimonio.TabIndex = 0;
            this.grpPatrimonio.TabStop = false;
            this.grpPatrimonio.Text = "Total Patrimonio";
            // 
            // grpSueldo
            // 
            this.grpSueldo.Controls.Add(this.dtpFechaIngreso);
            this.grpSueldo.Controls.Add(this.comboMesIngreso);
            this.grpSueldo.Controls.Add(this.btnNuevoIngreso);
            this.grpSueldo.Controls.Add(this.txtNuevoIngreso);
            this.grpSueldo.Location = new System.Drawing.Point(671, 30);
            this.grpSueldo.Name = "grpSueldo";
            this.grpSueldo.Size = new System.Drawing.Size(620, 100);
            this.grpSueldo.TabIndex = 1;
            this.grpSueldo.TabStop = false;
            this.grpSueldo.Text = "Generar Nuevo Ingreso";
            // 
            // btnNuevoIngreso
            // 
            this.btnNuevoIngreso.Location = new System.Drawing.Point(228, 71);
            this.btnNuevoIngreso.Name = "btnNuevoIngreso";
            this.btnNuevoIngreso.Size = new System.Drawing.Size(164, 23);
            this.btnNuevoIngreso.TabIndex = 1;
            this.btnNuevoIngreso.Text = "Cargar Nuevo Ingreso";
            this.btnNuevoIngreso.UseVisualStyleBackColor = true;
            this.btnNuevoIngreso.Click += new System.EventHandler(this.btnNuevoIngreso_Click);
            // 
            // txtNuevoIngreso
            // 
            this.txtNuevoIngreso.Location = new System.Drawing.Point(239, 39);
            this.txtNuevoIngreso.Name = "txtNuevoIngreso";
            this.txtNuevoIngreso.Size = new System.Drawing.Size(142, 22);
            this.txtNuevoIngreso.TabIndex = 0;
            // 
            // dgvDeudas
            // 
            this.dgvDeudas.AllowUserToAddRows = false;
            this.dgvDeudas.AllowUserToDeleteRows = false;
            this.dgvDeudas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudas.Location = new System.Drawing.Point(6, 21);
            this.dgvDeudas.MultiSelect = false;
            this.dgvDeudas.Name = "dgvDeudas";
            this.dgvDeudas.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeudas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDeudas.RowHeadersVisible = false;
            this.dgvDeudas.RowHeadersWidth = 51;
            this.dgvDeudas.RowTemplate.Height = 24;
            this.dgvDeudas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeudas.Size = new System.Drawing.Size(608, 189);
            this.dgvDeudas.TabIndex = 2;
            // 
            // grpDeudas
            // 
            this.grpDeudas.Controls.Add(this.dgvDeudas);
            this.grpDeudas.Location = new System.Drawing.Point(22, 149);
            this.grpDeudas.Name = "grpDeudas";
            this.grpDeudas.Size = new System.Drawing.Size(620, 273);
            this.grpDeudas.TabIndex = 1;
            this.grpDeudas.TabStop = false;
            this.grpDeudas.Text = "Deudas";
            // 
            // grpPagos
            // 
            this.grpPagos.Controls.Add(this.dgvPagos);
            this.grpPagos.Location = new System.Drawing.Point(22, 452);
            this.grpPagos.Name = "grpPagos";
            this.grpPagos.Size = new System.Drawing.Size(620, 273);
            this.grpPagos.TabIndex = 3;
            this.grpPagos.TabStop = false;
            this.grpPagos.Text = "Pagos";
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(6, 21);
            this.dgvPagos.MultiSelect = false;
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPagos.RowHeadersVisible = false;
            this.dgvPagos.RowHeadersWidth = 51;
            this.dgvPagos.RowTemplate.Height = 24;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(608, 189);
            this.dgvPagos.TabIndex = 2;
            // 
            // grpIngresos
            // 
            this.grpIngresos.Controls.Add(this.dgvIngresos);
            this.grpIngresos.Location = new System.Drawing.Point(671, 149);
            this.grpIngresos.Name = "grpIngresos";
            this.grpIngresos.Size = new System.Drawing.Size(620, 273);
            this.grpIngresos.TabIndex = 3;
            this.grpIngresos.TabStop = false;
            this.grpIngresos.Text = "Ingresos";
            // 
            // dgvIngresos
            // 
            this.dgvIngresos.AllowUserToAddRows = false;
            this.dgvIngresos.AllowUserToDeleteRows = false;
            this.dgvIngresos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresos.Location = new System.Drawing.Point(6, 21);
            this.dgvIngresos.MultiSelect = false;
            this.dgvIngresos.Name = "dgvIngresos";
            this.dgvIngresos.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngresos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvIngresos.RowHeadersVisible = false;
            this.dgvIngresos.RowHeadersWidth = 51;
            this.dgvIngresos.RowTemplate.Height = 24;
            this.dgvIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngresos.Size = new System.Drawing.Size(608, 189);
            this.dgvIngresos.TabIndex = 2;
            // 
            // grpExtracciones
            // 
            this.grpExtracciones.Controls.Add(this.dgvExtracciones);
            this.grpExtracciones.Location = new System.Drawing.Point(671, 452);
            this.grpExtracciones.Name = "grpExtracciones";
            this.grpExtracciones.Size = new System.Drawing.Size(620, 273);
            this.grpExtracciones.TabIndex = 4;
            this.grpExtracciones.TabStop = false;
            this.grpExtracciones.Text = "Extracciones";
            // 
            // dgvExtracciones
            // 
            this.dgvExtracciones.AllowUserToAddRows = false;
            this.dgvExtracciones.AllowUserToDeleteRows = false;
            this.dgvExtracciones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvExtracciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtracciones.Location = new System.Drawing.Point(6, 21);
            this.dgvExtracciones.MultiSelect = false;
            this.dgvExtracciones.Name = "dgvExtracciones";
            this.dgvExtracciones.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExtracciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvExtracciones.RowHeadersVisible = false;
            this.dgvExtracciones.RowHeadersWidth = 51;
            this.dgvExtracciones.RowTemplate.Height = 24;
            this.dgvExtracciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExtracciones.Size = new System.Drawing.Size(608, 189);
            this.dgvExtracciones.TabIndex = 2;
            // 
            // comboMesIngreso
            // 
            this.comboMesIngreso.FormattingEnabled = true;
            this.comboMesIngreso.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.comboMesIngreso.Location = new System.Drawing.Point(493, 38);
            this.comboMesIngreso.Name = "comboMesIngreso";
            this.comboMesIngreso.Size = new System.Drawing.Size(121, 24);
            this.comboMesIngreso.TabIndex = 2;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(23, 39);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(94, 22);
            this.dtpFechaIngreso.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 743);
            this.Controls.Add(this.grpExtracciones);
            this.Controls.Add(this.grpIngresos);
            this.Controls.Add(this.grpPagos);
            this.Controls.Add(this.grpDeudas);
            this.Controls.Add(this.grpSueldo);
            this.Controls.Add(this.grpPatrimonio);
            this.Name = "Form1";
            this.Text = "Estirar Sueldo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSueldo.ResumeLayout(false);
            this.grpSueldo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).EndInit();
            this.grpDeudas.ResumeLayout(false);
            this.grpPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.grpIngresos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).EndInit();
            this.grpExtracciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtracciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatrimonio;
        private System.Windows.Forms.GroupBox grpSueldo;
        private System.Windows.Forms.Button btnNuevoIngreso;
        private System.Windows.Forms.TextBox txtNuevoIngreso;
        private System.Windows.Forms.DataGridView dgvDeudas;
        private System.Windows.Forms.GroupBox grpDeudas;
        private System.Windows.Forms.GroupBox grpPagos;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.GroupBox grpIngresos;
        private System.Windows.Forms.DataGridView dgvIngresos;
        private System.Windows.Forms.GroupBox grpExtracciones;
        private System.Windows.Forms.DataGridView dgvExtracciones;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.ComboBox comboMesIngreso;
    }
}

