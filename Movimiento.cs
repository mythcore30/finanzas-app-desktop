using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasApp
{
    public class Movimiento
    {
        public int Id;
        public double Monto;
        public string Concepto;
        public TipoMovimiento movimiento;
        public DateTime fecha;
    }

    public enum TipoMovimiento
    {
        Egreso,
        Ingreso
    }
}
