using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estirar_Sueldo
{
    public class Extracción
    {
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Comentarios { get; set; }

        public Extracción(DateTime fecha, decimal monto, string comentarios)
        {
            Fecha = fecha;
            Monto = monto;
            Comentarios = comentarios;
        }
    }
    
      
    
}
