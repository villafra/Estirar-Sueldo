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
        public Form1()
        {
            InitializeComponent();
            EstirarSueldo estirar = new EstirarSueldo();
            dgvDeudas.DataSource = estirar.CargarDeudas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
