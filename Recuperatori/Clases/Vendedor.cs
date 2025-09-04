using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEmpleados
{
    public class Vendedor : Empleado
    {
        public int MontoVentasMensuales { get; set; }
        public override int CalcularSueldoFinal()
        {
            return SueldoBase + MontoVentasMensuales * 1000;
        }

        public override string TipoEmpleado()
        {
            return "Vendedor";
        }
    }
}
