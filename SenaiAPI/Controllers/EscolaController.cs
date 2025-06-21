using Microsoft.AspNetCore.Mvc;
using SenaiAPI.DTos;
using SenaiAPI.Entidades;
using SenaiAPI.Servicos.Interface;

namespace SenaiAPI.Controllers
{
    [ApiController]
    [Route("[controller]/api/v1")]
    public class EscolaController : ControllerBase
    {
        private readonly IEscolaService _escolaService;

        public EscolaController(IEscolaService escolaService) 
        {
            _escolaService = escolaService;  
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Adicionar([FromBody]EscolaDTo escola)
        {
            if (escola == null) 
            {
                return BadRequest("Escola não pode ser nula");
            }
            _escolaService.Salvar(escola);
            return Ok();
        }

        [HttpGet("buscar-todos")]
        public IActionResult Buscar()
        {
            var escolas = _escolaService.BuscarTodos();
            return Ok(escolas);
        }

        [HttpDelete]
        public async Task<IActionResult> Remover(long id)
        {
            await _escolaService.Remover(id);
            return Ok();
        }

        [HttpPost]
        [Route("Editar")]
        public IActionResult Editar([FromBody] EscolaEdicaoDTo escola) 
        {
            if (escola == null) 
            {
                return BadRequest("Escola não pode ser nula");
            }
            _escolaService.Editar(escola);
            return Ok();
        }
        [HttpGet]
        [Route("PegarPorId")]
        public IActionResult PegarPorId(long id)
        {
            var escolas = _escolaService.ObterPorId(id);
            return Ok(escolas);
        }


    }
}
