using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReportedeTiempoMVC.Models
{
    public class ActividadesViewModel
    {
        [ScaffoldColumn(false)]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Usuario")]
        public int IdUsuario { get; set; }
        public string Descripcion { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }

        [Display(Name = "Tiempo Reportado")]
        public double TiempoReportado { get; set; }
    }
}
