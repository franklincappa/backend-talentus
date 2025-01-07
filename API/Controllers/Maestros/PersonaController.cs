using Application.DTOs.Maestros;
using Core.Entities;
using Core.Entities.Maestros;
using Core.Interfaces;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Maestros
{
    [Route("api/v1/maestros/personas")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        //private readonly IPersonaRepository _repository;
        private readonly PersonaService _personaService;
        protected APIResponse _response;

        public PersonaController(PersonaService personaService)
        {
            //_repository = repository;
            _personaService = personaService;
            _response = new ();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] bool? activo=null)
        {
            var personas = await _personaService.GetAllAsync();
            _response.Data = personas;
            return Ok(_response);
        }

        [HttpGet("{idPersona}")]
        public async Task<IActionResult> GetById(long idPersona)
        {
            var persona = await _personaService.GetByIdAsync(idPersona);
            if (persona == null) {
                _response.Success = false;
                _response.StatusCode = System.Net.HttpStatusCode.NotFound;
                return NotFound(_response);
            } 
            _response.Data = persona;
            return Ok(_response);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PersonaRequestDTO request)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "userId")?.Value;
            var host = Request.Headers["X-Host"].ToString();

            var persona = new Persona
            {
                IdTipoDocumento = request.IdTipoDocumento,
                NroDocumento = request.NroDocumento,
                Nombres = request.Nombres,
                ApellidoPaterno = request.ApellidoPaterno,
                ApellidoMaterno = request.ApellidoMaterno,
                FechaNacimiento = request.FechaNacimiento,
                IdPais = request.IdPais,
                Ubigeo = request.Ubigeo,
                IdSexo = request.IdSexo,
                IdEstadoCivil = request.IdEstadoCivil,
                Ciudad = request.Ciudad,
                Direccion = request.Direccion,
                Telefono = request.Telefono,
                IdProfesion = request.IdProfesion,
                Ruc = request.Ruc,
                IdTipoSangre = request.IdTipoSangre,
                IdRegimenPension = request.IdRegimenPension,
                Notas = request.Notas,
                Activo = request.Activo
            };
            var id = await _personaService.AddAsync(persona, long.Parse(userId), host);
            return CreatedAtAction(nameof(GetById), new { id }, new { id });
        }

        [HttpPut("{idPersona}")]
        public async Task<IActionResult> Update(long id, [FromBody] PersonaRequestDTO request)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "userId")?.Value;
            var host = Request.Headers["X-Host"].ToString();

            var persona = new Persona
            {
                IdPersona = request.IdPersona,
                IdTipoDocumento = request.IdTipoDocumento,
                NroDocumento = request.NroDocumento,
                Nombres = request.Nombres,
                ApellidoPaterno = request.ApellidoPaterno,
                ApellidoMaterno = request.ApellidoMaterno,
                FechaNacimiento = request.FechaNacimiento,
                IdPais = request.IdPais,
                Ubigeo = request.Ubigeo,
                IdSexo = request.IdSexo,
                IdEstadoCivil = request.IdEstadoCivil,
                Ciudad = request.Ciudad,
                Direccion = request.Direccion,
                Telefono = request.Telefono,
                IdProfesion = request.IdProfesion,
                Ruc = request.Ruc,
                IdTipoSangre = request.IdTipoSangre,
                IdRegimenPension = request.IdRegimenPension,
                Notas = request.Notas,
                Activo = request.Activo
            };

            var result = await _personaService.UpdateAsync(id, persona, long.Parse(userId), host);
            if (!result) return NotFound();
            return NoContent();
        }

        /*
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var result = await _personaService.DeleteAsync(id);
            if (!result) return NotFound();
            return NoContent();
        }
        */
    }
}
