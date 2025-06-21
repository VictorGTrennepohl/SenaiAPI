using AutoMapper;
using SenaiAPI.DTos;
using SenaiAPI.Entidades;
using SenaiAPI.Repositorios.Interfaces;
using SenaiAPI.Servicos.Interface;

namespace SenaiAPI.Servicos
{
    public class EscolaService : IEscolaService
    {
        private readonly IMapper _mapper;
        private readonly IEscolaRepository _escolaRepository;

        public EscolaService(IMapper mapper, IEscolaRepository escolaRepository)
        {
            _mapper = mapper;
            _escolaRepository = escolaRepository;
        }

        public void Salvar(EscolaDTo escolaDTo)
        {
            var escola = _mapper.Map<Escola>(escolaDTo);
            _escolaRepository.Salvar(escola);
        }

        public List<EscolaDTo> BuscarTodos()
        {
            var escola = _escolaRepository.PegarTodos();
            return _mapper.Map<List<EscolaDTo>>(escola);
        }

        public async Task Remover(long id) 
        {
             await _escolaRepository.Remover(id);
        }

        public void Editar(EscolaEdicaoDTo model) 
        {
            var escola = _escolaRepository.ObterPorId(model.Id);
            _mapper.Map(model, escola);
            _escolaRepository.Salvar(escola);
        }

        public EscolaDTo ObterPorId(long id)
        {
            var escola = _escolaRepository.ObterPorId(id);
            return _mapper.Map<EscolaDTo>(escola);
        }
    }
}
