using AutoMapper;
using SenaiAPI.DTos;
using SenaiAPI.Entidades;
using SenaiAPI.Repositorios;
using SenaiAPI.Repositorios.Interfaces;
using SenaiAPI.Servicos.Interface;

namespace SenaiAPI.Servicos
{
    public class ProfessorService : IProfessorService
    {
        private readonly IMapper _mapper;
        private readonly IProfessorRepository _professorRepository;

        public ProfessorService(IMapper mapper, IProfessorRepository professorRepository)
        {
            _mapper = mapper;
            _professorRepository = professorRepository;
        }

        public void Salvar(ProfessorDTo professorDTo)
        {
            var professor = _mapper.Map<Professor>(professorDTo);
            _professorRepository.Salvar(professor);
        }
        public List<ProfessorDTo> BuscarTodos()
        {
            var professor = _professorRepository.PegarTodos();
            return _mapper.Map<List<ProfessorDTo>>(professor);
        }

        public async Task Remover(long id)
        {
            await _professorRepository.Remover(id);
        }

        public void Editar(ProfessorEdicaoDTo model)
        {
            var professor = _professorRepository.ObterPorId(model.Id);
            _mapper.Map(model, professor);
            _professorRepository.Salvar(professor);
        }
    }
}
