using Microsoft.AspNetCore.Mvc;
using SenaiAPI.DTos;
using SenaiAPI.Servicos.Interface;

namespace SenaiAPI.Controllers
{
    [ApiController]
    [Route("[controller]/api/v1")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpPost]
        public IActionResult Adicionar(EnderecoDTo endereco)
        {
            _enderecoService.Salvar(endereco);
            return Ok();
        }

        [HttpGet("buscar-todos")]
        public IActionResult Buscar()
        {
            var enderecos = _enderecoService.BuscarTodos();
            return Ok(enderecos);
        }

        [HttpDelete]
        public async Task<IActionResult> Remover(long id)
        {
            await _enderecoService.Remover(id);
            return Ok();
        }

        [HttpPost]
        [Route("Editar")]
        public IActionResult Editar([FromBody] EnderecoEdicaoDTo endereco)
        {
            if (endereco == null)
            {
                return BadRequest("Endereço não pode ser nula");
            }
            _enderecoService.Editar(endereco);
            return Ok();
        }
    }
       
}
