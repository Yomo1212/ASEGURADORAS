using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEGURADORAS
{
    public class CalculadoraPagoSeguro
    {
        // Propiedades de entrada
        public decimal MontoTotal { get; set; }
        public decimal Deducible { get; set; }
        public decimal CopagoPorcentaje { get; set; }

        // Propiedades de salida
        public decimal PagoPaciente { get; private set; }
        public decimal PagoAseguradora { get; private set; }

        public bool Calcular()
        {
            // Validar Monto no drs menor o igual a cero
            if (MontoTotal <= 0 || Deducible < 0 || CopagoPorcentaje < 0)
                return false;

            // Convertir porcentaje a decimal (por ejemplo, 15 => 0.15)
            decimal copagoDecimal = CopagoPorcentaje / 100m;

            // Cálculo del pago del paciente
            PagoPaciente = (MontoTotal - Deducible) * copagoDecimal + Deducible;

            // Cálculo del pago de la aseguradora
            PagoAseguradora = MontoTotal - PagoPaciente;

            return true;
        }
    }

}
