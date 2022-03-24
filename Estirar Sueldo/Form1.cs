using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estirar_Sueldo
{
    public partial class Form1 : Form
    {
        EstirarSueldo estirar = new EstirarSueldo();
        public Form1()
        {
            InitializeComponent();
            
            dgvDeudas.DataSource = estirar.CargarDeudas();
            dgvIngresos.DataSource = estirar.CargarSueldos();
            dgvPagos.DataSource = estirar.CargarPagos();
            dgvExtracciones.DataSource = estirar.CargarExtracciones();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNuevoIngreso_Click(object sender, EventArgs e)
        {
            Sueldo nuevoSueldo = new Sueldo(dtpFechaIngreso.Value, Convert.ToDecimal(txtNuevoIngreso.Text),comboMesIngreso.SelectedItem.ToString());
            estirar.IngresarSueldo(nuevoSueldo);
        }
    }
}
