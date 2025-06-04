using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEGURADORAS.Models
{
    public class MapfrePago
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Carnet { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        public decimal MontoTotal { get; set; }

        [Required]
        public decimal Deducible { get; set; }

        [Required]
        public decimal CopagoPorcentaje { get; set; }

        public decimal PagoPaciente { get; set; }

        public decimal PagoAseguradora { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}