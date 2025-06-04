using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEGURADORAS.Models
{
    public class Pago
    {
        public decimal MontoTotal { get; set; }
        public decimal Deducible { get; set; }
        public decimal CopagoPorcentaje { get; set; }
        public decimal PagoPaciente { get; set; }
        public decimal PagoAseguradora { get; set; }
        public string TipoPago { get; set; }
    }
}