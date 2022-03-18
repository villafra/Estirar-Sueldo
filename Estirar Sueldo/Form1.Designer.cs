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
            this.grpPatrimonio = new System.Windows.Forms.GroupBox();
            this.grpSueldo = new System.Windows.Forms.GroupBox();
            this.btnNuevoIngreso = new System.Windows.Forms.Button();
            this.txtNuevoIngreso = new System.Windows.Forms.TextBox();
            this.dgvDeudas = new System.Windows.Forms.DataGridView();
            this.grpSueldo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).BeginInit();
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
            this.btnNuevoIngreso.Location = new System.Drawing.Point(348, 43);
            this.btnNuevoIngreso.Name = "btnNuevoIngreso";
            this.btnNuevoIngreso.Size = new System.Drawing.Size(164, 23);
            this.btnNuevoIngreso.TabIndex = 1;
            this.btnNuevoIngreso.Text = "Cargar Nuevo Ingreso";
            this.btnNuevoIngreso.UseVisualStyleBackColor = true;
            // 
            // txtNuevoIngreso
            // 
            this.txtNuevoIngreso.Location = new System.Drawing.Point(108, 43);
            this.txtNuevoIngreso.Name = "txtNuevoIngreso";
            this.txtNuevoIngreso.Size = new System.Drawing.Size(163, 22);
            this.txtNuevoIngreso.TabIndex = 0;
            // 
            // dgvDeudas
            // 
            this.dgvDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudas.Location = new System.Drawing.Point(671, 159);
            this.dgvDeudas.Name = "dgvDeudas";
            this.dgvDeudas.RowHeadersWidth = 51;
            this.dgvDeudas.RowTemplate.Height = 24;
            this.dgvDeudas.Size = new System.Drawing.Size(240, 150);
            this.dgvDeudas.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 528);
            this.Controls.Add(this.dgvDeudas);
            this.Controls.Add(this.grpSueldo);
            this.Controls.Add(this.grpPatrimonio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSueldo.ResumeLayout(false);
            this.grpSueldo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatrimonio;
        private System.Windows.Forms.GroupBox grpSueldo;
        private System.Windows.Forms.Button btnNuevoIngreso;
        private System.Windows.Forms.TextBox txtNuevoIngreso;
        private System.Windows.Forms.DataGridView dgvDeudas;
    }
}

