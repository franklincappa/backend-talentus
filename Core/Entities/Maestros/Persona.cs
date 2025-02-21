﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Maestros
{
    public class Persona
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
        public string Notas { get; set; }
        public bool Activo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string HostCreacion { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime FechaModifica { get; set; }
        public string HostModifica { get; set; }
    }
}
