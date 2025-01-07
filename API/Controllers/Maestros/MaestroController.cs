using Core.Entities;
using Core.Entities.Maestros;
using Core.Interfaces;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;

namespace API.Controllers.Maestros
{
    [Route("api/v1/maestros")]
    [ApiController]
    public class MaestroController : ControllerBase
    {
        protected APIResponse _response;
        //private readonly IUbigeoRepository _ubigeoRepository;
        private readonly ILogger _logger;
        private readonly UbigeoService _ubigeoService;
        private readonly TablaService _tablaService;

        public MaestroController(UbigeoService ubigeoService, TablaService tablaService)
        {
            _response = new();
            _ubigeoService = ubigeoService;
            _tablaService = tablaService;
        }
        
        [HttpGet("{tabla}")]
        public async Task<IActionResult> ObtenerPorTabla(string tabla)
        {
            var registros = await _tablaService.ObtenerPorTablaAsync(tabla);
            _response.Data = registros;
            return Ok(_response);
        }

        // Endpoint para obtener un registro específico por tabla y código
        [HttpGet("{tabla}/{codigo}")]
        public async Task<IActionResult> ObtenerPorTablaYCodigo(string tabla, string codigo)
        {
            var registro = await _tablaService.ObtenerPorTablaYCodigoAsync(tabla, codigo);
            _response.Data = registro; 
            return Ok(_response);
        }

        //Tabla Sexo
        [HttpGet("sexo")]
        public async Task<IActionResult> ObtenerTablaSexo()
        {
            var registros = await _tablaService.ObtenerPorTablaAsync("SEXO");
            _response.Data = registros;
            return Ok(_response);
        }

        [HttpGet("sexo/{IdSexo}")]
        public async Task<IActionResult> ObtenerTablaSexoPorId(string IdSexo)
        {
            var registro = await _tablaService.ObtenerPorTablaYCodigoAsync("SEXO", IdSexo);
            _response.Data= registro;
            return Ok(_response); 
        }

        //Tabla Tipo Sangre
        [HttpGet("tipo-sangre")]
        public async Task<IActionResult> ObtenerTablaGrupoSanguineo()
        {
            var registros = await _tablaService.ObtenerPorTablaAsync("TIPO_SANGRE");
            _response.Data = registros;
            return Ok(_response);
        }

        [HttpGet("tipo-sangre/{IdTipoSangre}")]
        public async Task<IActionResult> ObtenerTablaGrupoSanguineoPorId(string IdTipoSangre)
        {
            var registro = await _tablaService.ObtenerPorTablaYCodigoAsync("TIPO_SANGRE", IdTipoSangre);
            _response.Data = registro;
            return Ok(_response);
        }

        //Tabla Tipo Documento
        [HttpGet("tipo-documento")]
        public async Task<IActionResult> ObtenerTablaTipoDocumento()
        {
            var registros = await _tablaService.ObtenerPorTablaAsync("TIPO_DOCUMENTO");
            _response.Data = registros;
            return Ok(_response);
        }

        [HttpGet("tipo-documento/{IdTipoDocumento}")]
        public async Task<IActionResult> ObtenerTablaTipoDocumentoPorId(string IdTipoDocumento)
        {
            var registro = await _tablaService.ObtenerPorTablaYCodigoAsync("TIPO_DOCUMENTO", IdTipoDocumento);
            _response.Data = registro;
            return Ok(_response);
        }

        //Tabla Estado Civil
        [HttpGet("estado-civil")]
        public async Task<IActionResult> ObtenerTablaEstadoCivil()
        {
            var registros = await _tablaService.ObtenerPorTablaAsync("ESTADO_CIVIL");
            _response.Data = registros;
            return Ok(_response);
        }

        [HttpGet("estado-civil/{IdEstadoCivil}")]
        public async Task<IActionResult> ObtenerTablaEstadoCivilPorId(string IdEstadoCivil)
        {
            var registro = await _tablaService.ObtenerPorTablaYCodigoAsync("ESTADO_CIVIL", IdEstadoCivil);
            _response.Data = registro;
            return Ok(_response);
        }

        //Tabla Regimen Pensión
        [HttpGet("regimen-pension")]
        public async Task<IActionResult> ObtenerTablaRegimenPension()
        {
            var registros = await _tablaService.ObtenerPorTablaAsync("REGIMEN_PENSION");
            _response.Data = registros;
            return Ok(_response);
        }

        [HttpGet("regimen-pension/{IdRegimenPension}")]
        public async Task<IActionResult> ObtenerTablaRegimenPensionPorId(string IdRegimenPension)
        {
            var registro = await _tablaService.ObtenerPorTablaYCodigoAsync("REGIMEN_PENSION", IdRegimenPension);
            _response.Data = registro;
            return Ok(_response);
        }

        //UBIGEOS
        [HttpGet("ubigeos")]
        public async Task<IActionResult> GetAllUbigeos()
        {
            var ubigeos = await _ubigeoService.GetAllAsync();
            _response.Data = ubigeos;
            return Ok(_response);             
        }


        [HttpGet("ubigeos/{codigo}")]
        public async Task<IActionResult> GetUbigeoByCodigo(string codigo)
        {
            var ubigeo = await _ubigeoService.GetByIdAsync(codigo);
            if (ubigeo == null)
            {
                _response.Success = false;
                _response.Message = $"El ubigeo con código {codigo} no fue encontrado.";
                return NotFound(_response);
            }
            _response.Data = ubigeo;
            return Ok(_response);
        }

    }
}
