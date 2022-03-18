using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estirar_Sueldo
{
    public abstract class Ingreso
    {
        protected Ingreso(DateTime fecha, decimal monto)
        {
            Fecha = fecha;
            Monto = monto;
        }

        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }

    }

    public class Sueldo: Ingreso
    {
        public Sueldo(DateTime fecha, decimal monto,  string mes) : base(fecha, monto)
        {
            Fecha = fecha;
            Monto = monto;
            Mes = mes;
        }

        public string Mes { get; set; }

    }

    public class Misceláneo : Ingreso
    {
        public Misceláneo(DateTime fecha, decimal monto,  string motivo): base(fecha, monto)
        {
            Fecha = fecha;
            Monto = monto;
            Motivo = motivo;
        }

        public string Motivo { get; set; }
    }
}
