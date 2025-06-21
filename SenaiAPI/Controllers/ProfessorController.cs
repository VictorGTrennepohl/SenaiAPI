using Microsoft.AspNetCore.Mvc;
using SenaiAPI.DTos;
using SenaiAPI.Servicos;
using SenaiAPI.Servicos.Interface;

namespace SenaiAPI.Controllers
{
    [ApiController]
    [Route("[controller]/api/v1")]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorService _professorService;

        public ProfessorController(IProfessorService professorService)
        {
            _professorService = professorService;
        }

        [HttpPost]
        public IActionResult Adicionar(ProfessorDTo professor)
        {
            _professorService.Salvar(professor);
            return Ok();
        }

        [HttpGet("buscar-todos")]
        public IActionResult Buscar()
        {
            var professores = _professorService.BuscarTodos();
            return Ok(professores);
        }

        [HttpDelete]
        public async Task<IActionResult> Remover(long id)
        {
            await _professorService.Remover(id);
            return Ok();
        }

        [HttpPost]
        [Route("Editar")]
        public IActionResult Editar([FromBody] ProfessorEdicaoDTo professor)
        {
            if (professor == null)
            {
                return BadRequest("Professor não pode ser nulo");
            }
            _professorService.Editar(professor);
            return Ok();
        }
    }
}
