using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estirar_Sueldo
{
    public class Deuda
    {
        public string Descripción { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Comentarios { get; set; }

        public Deuda(string descripción, decimal monto, DateTime fechaVencimiento, string comentarios)
        {
            Descripción = descripción;
            Monto = monto;
            FechaVencimiento = fechaVencimiento;
            Comentarios = comentarios;
        }
    }
}
