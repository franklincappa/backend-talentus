using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Maestros
{
    public class Tabla
    {
        [Key] 
        public short IdRegistro { get; set; }
        [Required] 
        public string NombreTabla { get; set; }
        [Required] 
        public string Codigo { get; set; }
        [Required] 
        public string Descripcion { get; set; }
        public int? Orden { get; set; }
        public bool Activo { get; set; }
    }
}
