using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Maestros
{
    public class PersonaRequestDTO
    {
        public long IdPersona { get; set; }
        public string IdTipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string IdPais { get; set; }
        public string Ubigeo { get; set; }
        public string IdSexo { get; set; }
        public string IdEstadoCivil { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public short? IdProfesion { get; set; }
        public string Ruc { get; set; }
        public string IdTipoSangre { get; set; }
        public string IdRegimenPension { get; set; }
        public string? Notas { get; set; }
        public bool Activo { get; set; }

    }
}
