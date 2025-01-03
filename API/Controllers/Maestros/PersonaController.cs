using Application.DTOs;
using Core.Entities.Maestros;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Maestros
{
    [Route("api/v1/maestros/personas")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaRepository _repository;

        public PersonaController(IPersonaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var personas = await _repository.GetAllAsync();
            return Ok(personas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var persona = await _repository.GetByIdAsync(id);
            if (persona == null) return NotFound();
            return Ok(persona);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] PersonaDTO dto)
        {
            var persona = new Persona
            {
                Nombres = dto.Nombre,
                ApellidoPaterno = dto.Apellido,
                ApellidoMaterno = dto.Documento
            };
            await _repository.AddAsync(persona);
            return CreatedAtAction(nameof(GetById), new { id = persona.Id }, persona);
        }
    }
}
